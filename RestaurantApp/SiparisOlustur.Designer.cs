namespace RestaurantApp
{
    partial class SiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            cmbMenuSelect = new ComboBox();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            lstCreateOrder = new ListBox();
            flowlpCreateOrder = new FlowLayoutPanel();
            btnAddLstCreateOrder = new Button();
            btnOrderConfirm = new Button();
            nudNumberOfMenu = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lblTotalPriceCreateOrder = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMenuSelect
            // 
            cmbMenuSelect.FormattingEnabled = true;
            cmbMenuSelect.Location = new Point(12, 126);
            cmbMenuSelect.Name = "cmbMenuSelect";
            cmbMenuSelect.Size = new Size(225, 23);
            cmbMenuSelect.TabIndex = 0;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(12, 307);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(58, 19);
            rbSmall.TabIndex = 3;
            rbSmall.TabStop = true;
            rbSmall.Text = "Küçük";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(94, 307);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(48, 19);
            rbMedium.TabIndex = 4;
            rbMedium.TabStop = true;
            rbMedium.Text = "Orta";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(179, 307);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(58, 19);
            rbLarge.TabIndex = 5;
            rbLarge.TabStop = true;
            rbLarge.Text = "Büyük";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // lstCreateOrder
            // 
            lstCreateOrder.FormattingEnabled = true;
            lstCreateOrder.ItemHeight = 15;
            lstCreateOrder.Location = new Point(306, 12);
            lstCreateOrder.Name = "lstCreateOrder";
            lstCreateOrder.Size = new Size(482, 319);
            lstCreateOrder.TabIndex = 6;
            // 
            // flowlpCreateOrder
            // 
            flowlpCreateOrder.Location = new Point(12, 155);
            flowlpCreateOrder.Name = "flowlpCreateOrder";
            flowlpCreateOrder.Size = new Size(225, 149);
            flowlpCreateOrder.TabIndex = 7;
            // 
            // btnAddLstCreateOrder
            // 
            btnAddLstCreateOrder.Location = new Point(12, 361);
            btnAddLstCreateOrder.Name = "btnAddLstCreateOrder";
            btnAddLstCreateOrder.Size = new Size(225, 38);
            btnAddLstCreateOrder.TabIndex = 8;
            btnAddLstCreateOrder.Text = "Ekle";
            btnAddLstCreateOrder.UseVisualStyleBackColor = true;
            btnAddLstCreateOrder.Click += btnAddLstCreateOrder_Click;
            // 
            // btnOrderConfirm
            // 
            btnOrderConfirm.Location = new Point(635, 337);
            btnOrderConfirm.Name = "btnOrderConfirm";
            btnOrderConfirm.Size = new Size(153, 62);
            btnOrderConfirm.TabIndex = 9;
            btnOrderConfirm.Text = "Siparişi Onayla";
            btnOrderConfirm.UseVisualStyleBackColor = true;
            btnOrderConfirm.Click += btnOrderConfirm_Click;
            // 
            // nudNumberOfMenu
            // 
            nudNumberOfMenu.Location = new Point(117, 332);
            nudNumberOfMenu.Name = "nudNumberOfMenu";
            nudNumberOfMenu.Size = new Size(120, 23);
            nudNumberOfMenu.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 334);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 11;
            label1.Text = "Adet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 354);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Toplam";
            // 
            // lblTotalPriceCreateOrder
            // 
            lblTotalPriceCreateOrder.AutoSize = true;
            lblTotalPriceCreateOrder.Location = new Point(488, 354);
            lblTotalPriceCreateOrder.Name = "lblTotalPriceCreateOrder";
            lblTotalPriceCreateOrder.Size = new Size(0, 15);
            lblTotalPriceCreateOrder.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(pictureBox1);
            Controls.Add(lblTotalPriceCreateOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudNumberOfMenu);
            Controls.Add(btnOrderConfirm);
            Controls.Add(btnAddLstCreateOrder);
            Controls.Add(flowlpCreateOrder);
            Controls.Add(lstCreateOrder);
            Controls.Add(rbLarge);
            Controls.Add(rbMedium);
            Controls.Add(rbSmall);
            Controls.Add(cmbMenuSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberOfMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMenuSelect;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private ListBox lstCreateOrder;
        private FlowLayoutPanel flowlpCreateOrder;
        private Button btnAddLstCreateOrder;
        private Button btnOrderConfirm;
        private NumericUpDown nudNumberOfMenu;
        private Label label1;
        private Label label2;
        private Label lblTotalPriceCreateOrder;
        private PictureBox pictureBox1;
    }
}