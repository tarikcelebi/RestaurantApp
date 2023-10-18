namespace RestaurantApp
{
    partial class MenuAdd
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
            grpboxMenuAdd = new GroupBox();
            btnMenuAdd = new Button();
            label2 = new Label();
            label1 = new Label();
            nudMenuPrice = new NumericUpDown();
            txtMenuName = new TextBox();
            grpboxMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuPrice).BeginInit();
            SuspendLayout();
            // 
            // grpboxMenuAdd
            // 
            grpboxMenuAdd.Controls.Add(btnMenuAdd);
            grpboxMenuAdd.Controls.Add(label2);
            grpboxMenuAdd.Controls.Add(label1);
            grpboxMenuAdd.Controls.Add(nudMenuPrice);
            grpboxMenuAdd.Controls.Add(txtMenuName);
            grpboxMenuAdd.Location = new Point(176, 57);
            grpboxMenuAdd.Name = "grpboxMenuAdd";
            grpboxMenuAdd.Size = new Size(425, 269);
            grpboxMenuAdd.TabIndex = 0;
            grpboxMenuAdd.TabStop = false;
            grpboxMenuAdd.Text = "Menü ekle";
            // 
            // btnMenuAdd
            // 
            btnMenuAdd.Location = new Point(79, 222);
            btnMenuAdd.Name = "btnMenuAdd";
            btnMenuAdd.Size = new Size(271, 23);
            btnMenuAdd.TabIndex = 4;
            btnMenuAdd.Text = "Ekle";
            btnMenuAdd.UseVisualStyleBackColor = true;
            btnMenuAdd.Click += btnMenuAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 167);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "Adı";
            // 
            // nudMenuPrice
            // 
            nudMenuPrice.Location = new Point(79, 159);
            nudMenuPrice.Name = "nudMenuPrice";
            nudMenuPrice.Size = new Size(271, 23);
            nudMenuPrice.TabIndex = 1;
            // 
            // txtMenuName
            // 
            txtMenuName.Location = new Point(79, 84);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(271, 23);
            txtMenuName.TabIndex = 0;
            // 
            // MenuAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpboxMenuAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuAdd";
            Text = "MenuEkle";
            Load += MenuAdd_Load;
            grpboxMenuAdd.ResumeLayout(false);
            grpboxMenuAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxMenuAdd;
        private Button btnMenuAdd;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMenuPrice;
        private TextBox txtMenuName;
    }
}