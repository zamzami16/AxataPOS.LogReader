using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using System.Windows.Forms;

namespace AxataPOS.App.Componen
{
    //public class AxataProgressBar : ProgressBar
    //{
    //    private System.Timers.Timer animationTimer;
    //    private int animationWidth = 80; // Width of the animation segment
    //    private int animationPosition = 0;
    //    private bool increasing = true;

    //    public Color ProgressColor { get; set; } = Color.BlueViolet;

    //    public AxataProgressBar()
    //    {
    //        this.SetStyle(ControlStyles.UserPaint, true);
    //        this.Style = ProgressBarStyle.Continuous;

    //        InitializeAnimationTimer();
    //    }

    //    private void InitializeAnimationTimer()
    //    {
    //        animationTimer = new System.Timers.Timer(50); // Adjust the interval as needed
    //        animationTimer.Elapsed += AnimationTimer_Tick;
    //        animationTimer.Start();
    //    }

    //    private void AnimationTimer_Tick(object sender, ElapsedEventArgs e)
    //    {
    //        if (increasing)
    //        {
    //            animationPosition += 2; // Adjust speed as needed
    //            if (animationPosition >= Width - animationWidth)
    //            {
    //                increasing = false;
    //            }
    //        }
    //        else
    //        {
    //            animationPosition -= 2; // Adjust speed as needed
    //            if (animationPosition <= 0)
    //            {
    //                increasing = true;
    //            }
    //        }

    //        this.Invalidate();
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        base.OnPaint(e);
    //        DrawContinuousAnimation(e.Graphics);
    //    }

    //    private void DrawContinuousAnimation(Graphics graphics)
    //    {
    //        Rectangle rec = new Rectangle(animationPosition, 0, animationWidth, Height);

    //        using (SolidBrush brush = new SolidBrush(ProgressColor))
    //        {
    //            graphics.FillRectangle(brush, rec);
    //        }
    //    }
    //}

    public class AxataProgressBar : ProgressBar
    {
        private System.Timers.Timer animationTimer;
        private int animationWidth = 100; // Width of the animation segment
        private int animationPosition = 30;
        private bool increasing = true;
        private static readonly Color DefaultColor = Color.FromArgb(2, 118, 255);

        public Color ProgressColor { get; set; } = DefaultColor;

        public AxataProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Style = ProgressBarStyle.Continuous;

            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Timers.Timer(50); // Adjust the interval as needed
            animationTimer.Elapsed += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, ElapsedEventArgs e)
        {
            if (increasing)
            {
                animationPosition += MarqueeAnimationSpeed; // Adjust speed as needed
                if (animationPosition >= Width - animationWidth)
                {
                    increasing = false;
                }
            }
            else
            {
                animationPosition -= MarqueeAnimationSpeed; // Adjust speed as needed
                if (animationPosition <= 0)
                {
                    increasing = true;
                }
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawRoundedContinuousAnimation(e.Graphics);
        }

        private void DrawRoundedContinuousAnimation(Graphics graphics)
        {
            int roundedRadius = Height / 2; // Adjust the radius to control the roundness

            Rectangle rec = new Rectangle(animationPosition, 0, animationWidth, Height);
            GraphicsPath path = GetRoundedRectangle(rec, roundedRadius);

            using (SolidBrush brush = new SolidBrush(ProgressColor))
            {
                graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;

            // Top right corner
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;

            // Bottom right corner
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;

            // Bottom left corner
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
