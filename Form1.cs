using System.Drawing.Drawing2D;

namespace InteractiveSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            switchImage = new Bitmap(pic_ButtonCanvas.Width, pic_ButtonCanvas.Height);
            imageSize[0] = switchImage.Width;
            imageSize[1] = switchImage.Height;

            updateGraphics();
        }

        private Bitmap switchImage;
        private int[] imageSize = { 0, 0 };

        private bool[] buffer_A = { true, false };
        private bool buffer_B = false;
        private bool buffer_C = false;

        private void switchToggle_A(object sender, EventArgs e)
        {
            bool prevState = buffer_A[0];
            buffer_A[0] = buffer_A[1];
            buffer_A[1] = prevState;

            radio_OFF.Checked = buffer_A[0];
            radio_ON.Checked = buffer_A[1];
        }

        private void btn_DynamicSwitchB_Click(object sender, EventArgs e)
        {
            buffer_B = !buffer_B;
            btn_DynamicSwitchB.Text = buffer_B ? "ON" : "OFF";
        }

        private void pic_ButtonCanvas_Click(object sender, EventArgs e)
        {
            if (!bgw_ImageSwitch.IsBusy)
            {
                bgw_ImageSwitch.RunWorkerAsync();
            }
        }

        private void btn_RefreshGraphic_Click(object sender, EventArgs e)
        {
            updateGraphics();
        }

        private float switchLocation = 0;

        private void updateGraphics(bool animateSwitch = false)
        {
            GraphicsPath gPath_Border = new GraphicsPath();
            Pen borderPen = new Pen(Color.Red, 5);
            Pen switchPen = new Pen(Color.Blue, 3);

            #region shaping
            gPath_Border.AddArc(2.5f, 2.5f, Convert.ToSingle(imageSize[1]) - 5f, Convert.ToSingle(imageSize[1]) - 5f, 90, 180);
            gPath_Border.AddArc(Convert.ToSingle(imageSize[0]) - 2.5f - (Convert.ToSingle(imageSize[1]) - 5f), 2.5f, Convert.ToSingle(imageSize[1]) - 5f, Convert.ToSingle(imageSize[1]) - 5f, 270, 180);
            gPath_Border.CloseFigure();
            #endregion

            using (Graphics g = Graphics.FromImage(switchImage))
            {
                g.Clear(Color.Transparent);
                g.DrawPath(borderPen, gPath_Border);

                g.DrawArc(switchPen, 12.5f + switchLocation, 12.5f, 25, 25, 0, 360); // OFF SWITCH
                //g.DrawArc(switchPen, 62.5f, 12.5f, 25, 25, 0, 360); // ON SWITCH
            }

            pic_ButtonCanvas.Image = switchImage;
            pic_ButtonCanvas.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void bgw_ImageSwitch_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // OFF -> ON requires 50 units to the right
            // ON -> OFF requires 50 units to the left

            Invoke((MethodInvoker)delegate () { lbl_SwitchStatus.Text = "Status: ..."; });
            buffer_C = !buffer_C;
            if (switchLocation == 0)
            {
                for (int i = 0; i <= 50; i++)
                {
                    switchLocation = 50f * Convert.ToSingle(i / 50.0f);
                    updateGraphics(true);
                    Thread.Sleep(1);
                }
            }
            else
            {
                for (int i = 50; i >= 0; i--)
                {
                    switchLocation = 50f * Convert.ToSingle(i / 50.0f);
                    updateGraphics(true);
                    Thread.Sleep(1);
                }
            }
            Invoke((MethodInvoker)delegate () { lbl_SwitchStatus.Text = $"Status: {(buffer_C ? "ON":"OFF")}"; });
        }
    }
}
