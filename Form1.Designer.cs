namespace InteractiveSwitch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radio_ON = new RadioButton();
            radio_OFF = new RadioButton();
            groupBox2 = new GroupBox();
            btn_DynamicSwitchB = new Button();
            groupBox3 = new GroupBox();
            btn_RefreshGraphic = new Button();
            pic_ButtonCanvas = new PictureBox();
            bgw_ImageSwitch = new System.ComponentModel.BackgroundWorker();
            lbl_SwitchStatus = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ButtonCanvas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_ON);
            groupBox1.Controls.Add(radio_OFF);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(563, 70);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Switch Type 1 - Radio Buttons in a group";
            // 
            // radio_ON
            // 
            radio_ON.AutoSize = true;
            radio_ON.Location = new Point(75, 31);
            radio_ON.Margin = new Padding(4);
            radio_ON.Name = "radio_ON";
            radio_ON.Size = new Size(52, 25);
            radio_ON.TabIndex = 1;
            radio_ON.TabStop = true;
            radio_ON.Text = "ON";
            radio_ON.UseVisualStyleBackColor = true;
            radio_ON.Click += switchToggle_A;
            // 
            // radio_OFF
            // 
            radio_OFF.AutoSize = true;
            radio_OFF.Location = new Point(8, 31);
            radio_OFF.Margin = new Padding(4);
            radio_OFF.Name = "radio_OFF";
            radio_OFF.Size = new Size(56, 25);
            radio_OFF.TabIndex = 0;
            radio_OFF.TabStop = true;
            radio_OFF.Text = "OFF";
            radio_OFF.UseVisualStyleBackColor = true;
            radio_OFF.Click += switchToggle_A;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_DynamicSwitchB);
            groupBox2.Location = new Point(15, 95);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(563, 73);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Switch Type 2 - Button Switch";
            // 
            // btn_DynamicSwitchB
            // 
            btn_DynamicSwitchB.Location = new Point(8, 31);
            btn_DynamicSwitchB.Margin = new Padding(4);
            btn_DynamicSwitchB.Name = "btn_DynamicSwitchB";
            btn_DynamicSwitchB.Size = new Size(96, 32);
            btn_DynamicSwitchB.TabIndex = 0;
            btn_DynamicSwitchB.Text = "button1";
            btn_DynamicSwitchB.UseVisualStyleBackColor = true;
            btn_DynamicSwitchB.Click += btn_DynamicSwitchB_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_SwitchStatus);
            groupBox3.Controls.Add(btn_RefreshGraphic);
            groupBox3.Controls.Add(pic_ButtonCanvas);
            groupBox3.Location = new Point(15, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(563, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Switch Type 3 - Image";
            // 
            // btn_RefreshGraphic
            // 
            btn_RefreshGraphic.Location = new Point(482, 28);
            btn_RefreshGraphic.Name = "btn_RefreshGraphic";
            btn_RefreshGraphic.Size = new Size(75, 50);
            btn_RefreshGraphic.TabIndex = 1;
            btn_RefreshGraphic.Text = "Refresh Graphic";
            btn_RefreshGraphic.UseVisualStyleBackColor = true;
            btn_RefreshGraphic.Click += btn_RefreshGraphic_Click;
            // 
            // pic_ButtonCanvas
            // 
            pic_ButtonCanvas.BackColor = SystemColors.ButtonShadow;
            pic_ButtonCanvas.Location = new Point(8, 28);
            pic_ButtonCanvas.Name = "pic_ButtonCanvas";
            pic_ButtonCanvas.Size = new Size(100, 50);
            pic_ButtonCanvas.SizeMode = PictureBoxSizeMode.Zoom;
            pic_ButtonCanvas.TabIndex = 0;
            pic_ButtonCanvas.TabStop = false;
            pic_ButtonCanvas.Click += pic_ButtonCanvas_Click;
            // 
            // bgw_ImageSwitch
            // 
            bgw_ImageSwitch.DoWork += bgw_ImageSwitch_DoWork;
            // 
            // lbl_SwitchStatus
            // 
            lbl_SwitchStatus.AutoSize = true;
            lbl_SwitchStatus.Location = new Point(114, 43);
            lbl_SwitchStatus.Name = "lbl_SwitchStatus";
            lbl_SwitchStatus.Size = new Size(87, 21);
            lbl_SwitchStatus.TabIndex = 2;
            lbl_SwitchStatus.Text = "Status: OFF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 455);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_ButtonCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radio_ON;
        private RadioButton radio_OFF;
        private GroupBox groupBox2;
        private Button btn_DynamicSwitchB;
        private GroupBox groupBox3;
        private Button btn_RefreshGraphic;
        private PictureBox pic_ButtonCanvas;
        private System.ComponentModel.BackgroundWorker bgw_ImageSwitch;
        private Label lbl_SwitchStatus;
    }
}
