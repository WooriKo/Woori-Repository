using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace 그림판
{
    public partial class Drawing : Form
    {
        private bool isDrag = false;
        private Pen currentPen;
        private Point currentPoint, movePoint;
        private Point previousPoint;
        private int setTool = 0;    // 선 굵기
        private int setStrip = 0;   // 선 종류
        private ColorDialog clg;
        private string setShape = "pen";    // 도형
        private Graphics g;
        private Boolean isColorChanged = false;   // 색상
        private Boolean isChanged = false;
        private Boolean isOpened = false;

        Image image;
        Bitmap gBitmap;

        int width = 0, height = 0;

        // Paint를 하기 위해 추가
        // 도형들을 리스트로 갖고있음.
        private LinkedList<RectangleClass> shapes_cir = new LinkedList<RectangleClass>();
        private LinkedList<RectangleClass> shapes_rec = new LinkedList<RectangleClass>();
        private LinkedList<LineClass> shapes_line = new LinkedList<LineClass>();
        private LinkedList<LineClass> shapes_pen = new LinkedList<LineClass>();

        public Drawing()
        {
            InitializeComponent();

            // 초기값 설정
            currentPen = new Pen(Color.Black);
            previousPoint = new Point(0, 0);
            currentPoint = new Point(0, 0);

            g = pictureBox1.CreateGraphics();
        }

        private void menu_newfile_Click(object sender, EventArgs e)
        {
            // 변경된 내용이 있을시에만 저장알림창 뜨게 함.
            if (isChanged)
            {
                DialogResult dr = MessageBox.Show("수정된 내용을 저장하시겠습니까?", "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    // 비트맵 이용해서 저장
                    using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Title = "이미지 파일저장...";
                        saveFileDialog1.OverwritePrompt = true;
                        saveFileDialog1.Filter = "JPEG File(*.jpg)|*.jpg|Bitmap File(*.bmp)|*.bmp|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png";
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            string strFilename = saveFileDialog1.FileName;
                            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                            bmp.Save(@strFilename);

                            // 도형 리스트 비움
                            clear_lists();

                            isChanged = false;
                        }
                    }

                }
                if (dr == DialogResult.No)
                {
                    // 도형 리스트 비움
                    clear_lists();

                    g.Clear(Color.White);
                    this.Text = "제목 없음 - 그림판";
                    isChanged = false;
                }
            }
            else
            {
                g.Clear(Color.White);
                this.Text = "제목 없음 - 그림판";
            }
        }

        private void menu_savefile_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Title = "이미지 파일저장...";
                    saveFileDialog1.OverwritePrompt = true;
                    saveFileDialog1.Filter = "JPEG File(*.jpg)|*.jpg|Bitmap File(*.bmp)|*.bmp|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png";
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string strFilename = saveFileDialog1.FileName;
                        pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                        bmp.Save(@strFilename);

                        string[] myArr = strFilename.Split('\\');
                        this.Text = myArr[myArr.Length - 1] + " - 그림판";
                        isChanged = false;
                    }
                }
                isChanged = false;
            }
        }

        private void menu_openfile_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult dr = MessageBox.Show("수정된 내용을 저장하시겠습니까?", "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    menu_savefile_Click(sender, e);
                }
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }

            string openstrFilename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "이미지 읽기";
            openFileDialog1.Filter = "All Files(*.*)|*.*|Bitmap File(*.bmp)|*.bmp|JPEG File(*.jpg)|*.jpg";

            // 다이얼로그의 확인 처리
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 도형 리스트 비움
                clear_lists();

                g.Clear(Color.White);

                openstrFilename = openFileDialog1.FileName;
                image = Image.FromFile(openstrFilename);
                this.pictureBox1.Image = image;
                gBitmap = new Bitmap(image);
                pictureBox1.Image = gBitmap;

                string[] myArr = openstrFilename.Split('\\');
                this.Text = myArr[myArr.Length - 1] + " - 그림판";
                isOpened = true;
                isChanged = false;
            }

        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_drawcircle_Click(object sender, EventArgs e)
        {
            setShape = "circle";
        }

        private void menu_drawrectangle_Click(object sender, EventArgs e)
        {
            setShape = "rectangle";
        }

        private void menu_drawline_Click(object sender, EventArgs e)
        {
            setShape = "line";
        }

        private void menu_drawpen_Click(object sender, EventArgs e)
        {
            setShape = "pen";
        }

        private void menu_color_Click(object sender, EventArgs e)
        {
            clg = new ColorDialog();
            clg.ShowDialog();
            isColorChanged = true;
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clgBack = new ColorDialog();
            clgBack.ShowDialog();
            pictureBox1.BackColor = clgBack.Color;
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 1;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 2;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTool = 0;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 0;
        }

        private void dashdotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 2;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStrip = 1;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            previousPoint = new Point(e.X, e.Y);

            // 색 지정
            if (isColorChanged)
                currentPen = new Pen(clg.Color);

            // 선 두께 지정
            if (setTool == 0)
                currentPen.Width = 1;
            else if (setTool == 1)
                currentPen.Width = 10;
            else if (setTool == 2)
                currentPen.Width = 5;
            else if (setTool == 3)
                currentPen.Width = 3;

            // 선 종류 지정
            if (setStrip == 0)
                currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            else if (setStrip == 1)
                currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            else if (setStrip == 2)
                currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            isDrag = true;

            // 자유곡선 처리. 움직이는 좌표 받아와서 계속 라인 그려줌.
            if (e.Button == MouseButtons.Left && setShape.Equals("pen"))
            {
                // 불러오기 했을때 더블클릭시 선 그려짐 방지
                if (isOpened)
                {
                    isOpened = false;
                    isDrag = false;
                    return;
                }

                // 마우스 클릭한 상태에서 이동하는 실시간 좌표 값 저장 
                movePoint.X = e.X;
                movePoint.Y = e.Y;

                // 선 객체 생성
                LineClass myPen = new LineClass(previousPoint, movePoint);
                myPen.setPen(currentPen);
                shapes_pen.AddLast(myPen);

                draw_pen(g, currentPen, previousPoint, movePoint);
            } 
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                isChanged = true;
                g = pictureBox1.CreateGraphics();

                // 현재 위치 받아옴
                currentPoint = new Point(e.X, e.Y);

                // 그리기 모양 지정
                if (setShape.Equals("circle"))
                {
                    width = System.Math.Abs(currentPoint.X - previousPoint.X);
                    height = System.Math.Abs(currentPoint.Y - previousPoint.Y);

                    // 드래그하는 위치에 따라 도형의 시작 위치를 바꿔줌.
                    if (previousPoint.X > currentPoint.X && previousPoint.Y > currentPoint.Y)
                    {
                        previousPoint = currentPoint;
                    }
                    else if (previousPoint.Y > currentPoint.Y)
                    {
                        previousPoint.Y = currentPoint.Y;
                    }
                    else if (previousPoint.X > currentPoint.X)
                    {
                        previousPoint.X = currentPoint.X;
                    }

                    // 원형 객체 생성
                    RectangleClass myCircle = new RectangleClass(previousPoint, currentPoint, width, height);
                    myCircle.setPen(currentPen);
                    shapes_cir.AddLast(myCircle);

                    draw_circle(g, currentPen, previousPoint, currentPoint);
                }

                if (setShape.Equals("rectangle"))
                {
                    width = System.Math.Abs(currentPoint.X - previousPoint.X);
                    height = System.Math.Abs(currentPoint.Y - previousPoint.Y);

                    // 드래그하는 위치에 따라 도형의 시작 위치를 바꿔줌.
                    if (previousPoint.X > currentPoint.X && previousPoint.Y > currentPoint.Y)
                    {
                        previousPoint = currentPoint;
                    }
                    else if (previousPoint.Y > currentPoint.Y)
                    {
                        previousPoint.Y = currentPoint.Y;
                    }
                    else if (previousPoint.X > currentPoint.X)
                    {
                        previousPoint.X = currentPoint.X;
                    }

                    // 사각형 객체 생성
                    RectangleClass myRectangle = new RectangleClass(previousPoint, currentPoint, height, width);
                    myRectangle.setPen(currentPen);
                    shapes_rec.AddLast(myRectangle);

                    draw_rectangle(g, currentPen, previousPoint, currentPoint);
                }

                if (setShape.Equals("line"))
                {
                    // 선 객체 생성
                    LineClass myLine = new LineClass(previousPoint, currentPoint);
                    myLine.setPen(currentPen);
                    shapes_line.AddLast(myLine);

                    draw_line(g, currentPen, previousPoint, currentPoint);
                }
            }
            isDrag = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);
        }

        private void draw_circle(Graphics g, Pen currentPen, Point previousPoint, Point currentPoint)
        {
            g.DrawEllipse(currentPen, new Rectangle(previousPoint.X, previousPoint.Y, width, height));
            this.previousPoint = this.currentPoint;
        }
        private void draw_rectangle(Graphics g, Pen currentPen, Point previousPoint, Point currentPoint)
        {
            g.DrawRectangle(currentPen, new Rectangle(previousPoint.X, previousPoint.Y, width, height));
            this.previousPoint = this.currentPoint;
        }
        private void draw_line(Graphics g, Pen currentPen, Point previousPoint, Point currentPoint)
        {
            g.DrawLine(currentPen, previousPoint, currentPoint);
            this.previousPoint = this.currentPoint;
        }

        private void draw_pen(Graphics g, Pen currentPen, Point previousPoint, Point movePoint)
        {
            g.DrawLine(currentPen, previousPoint, movePoint);
            this.previousPoint = this.movePoint;
        }

        private void 모두지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 화면 비움
            g.Clear(Color.White);

            // 도형 리스트 비움
            clear_lists();
        }

        private void pictureBox_paint(object sender, PaintEventArgs e)
        {
            //Graphics grfx = pictureBox1.CreateGraphics();
            Graphics grfx = e.Graphics;

            foreach (RectangleClass info in shapes_rec)
            {
                //MessageBox.Show("paint");
                draw_rectangle(grfx, info.getPen(), info.getStartPoint(), info.getEndPoint());
            }
            foreach (RectangleClass info in shapes_cir)
            {
                draw_circle(grfx, info.getPen(), info.getStartPoint(), info.getEndPoint());
            }
            foreach (LineClass info in shapes_line)
            {
                draw_line(grfx, info.getPen(), info.getStartPoint(), info.getEndPoint());
            }
            foreach (LineClass info in shapes_pen)
            {
                draw_pen(grfx, info.getPen(), info.getStartPoint(), info.getEndPoint());
            }
        }

        private void clear_lists()
        {
            shapes_cir.Clear();
            shapes_line.Clear();
            shapes_pen.Clear();
            shapes_rec.Clear();
        }
    }
}
