namespace RestaurantApp
{
    partial class TumSiparisler
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
            lstTotalOrders = new ListBox();
            grpBoxCiro = new GroupBox();
            lblTotalEndorsement = new Label();
            grpBoxTotalOrder = new GroupBox();
            lblTotalOrderNumber = new Label();
            grpBoxExtraProductGaining = new GroupBox();
            lblExtraProductIncome = new Label();
            grpBoxSelledProducts = new GroupBox();
            lblTotalSoldProductNumber = new Label();
            label1 = new Label();
            grpBoxCiro.SuspendLayout();
            grpBoxTotalOrder.SuspendLayout();
            grpBoxExtraProductGaining.SuspendLayout();
            grpBoxSelledProducts.SuspendLayout();
            SuspendLayout();
            // 
            // lstTotalOrders
            // 
            lstTotalOrders.FormattingEnabled = true;
            lstTotalOrders.ItemHeight = 15;
            lstTotalOrders.Location = new Point(12, 25);
            lstTotalOrders.Name = "lstTotalOrders";
            lstTotalOrders.Size = new Size(574, 349);
            lstTotalOrders.TabIndex = 0;
            lstTotalOrders.SelectedIndexChanged += lstTotalOrders_SelectedIndexChanged;
            // 
            // grpBoxCiro
            // 
            grpBoxCiro.Controls.Add(lblTotalEndorsement);
            grpBoxCiro.Location = new Point(592, 7);
            grpBoxCiro.Name = "grpBoxCiro";
            grpBoxCiro.Size = new Size(200, 87);
            grpBoxCiro.TabIndex = 1;
            grpBoxCiro.TabStop = false;
            grpBoxCiro.Text = "Ciro";
            // 
            // lblTotalEndorsement
            // 
            lblTotalEndorsement.AutoSize = true;
            lblTotalEndorsement.Location = new Point(66, 46);
            lblTotalEndorsement.Name = "lblTotalEndorsement";
            lblTotalEndorsement.Size = new Size(0, 15);
            lblTotalEndorsement.TabIndex = 3;
            // 
            // grpBoxTotalOrder
            // 
            grpBoxTotalOrder.Controls.Add(lblTotalOrderNumber);
            grpBoxTotalOrder.Location = new Point(592, 100);
            grpBoxTotalOrder.Name = "grpBoxTotalOrder";
            grpBoxTotalOrder.Size = new Size(200, 83);
            grpBoxTotalOrder.TabIndex = 0;
            grpBoxTotalOrder.TabStop = false;
            grpBoxTotalOrder.Text = "Toplam Sipariş";
            // 
            // lblTotalOrderNumber
            // 
            lblTotalOrderNumber.AutoSize = true;
            lblTotalOrderNumber.Location = new Point(66, 45);
            lblTotalOrderNumber.Name = "lblTotalOrderNumber";
            lblTotalOrderNumber.Size = new Size(0, 15);
            lblTotalOrderNumber.TabIndex = 4;
            // 
            // grpBoxExtraProductGaining
            // 
            grpBoxExtraProductGaining.Controls.Add(lblExtraProductIncome);
            grpBoxExtraProductGaining.Location = new Point(592, 189);
            grpBoxExtraProductGaining.Name = "grpBoxExtraProductGaining";
            grpBoxExtraProductGaining.Size = new Size(200, 81);
            grpBoxExtraProductGaining.TabIndex = 0;
            grpBoxExtraProductGaining.TabStop = false;
            grpBoxExtraProductGaining.Text = "Ekstra Malzeme Geliri";
            // 
            // lblExtraProductIncome
            // 
            lblExtraProductIncome.AutoSize = true;
            lblExtraProductIncome.Location = new Point(66, 45);
            lblExtraProductIncome.Name = "lblExtraProductIncome";
            lblExtraProductIncome.Size = new Size(0, 15);
            lblExtraProductIncome.TabIndex = 5;
            // 
            // grpBoxSelledProducts
            // 
            grpBoxSelledProducts.Controls.Add(lblTotalSoldProductNumber);
            grpBoxSelledProducts.Location = new Point(592, 276);
            grpBoxSelledProducts.Name = "grpBoxSelledProducts";
            grpBoxSelledProducts.Size = new Size(200, 100);
            grpBoxSelledProducts.TabIndex = 0;
            grpBoxSelledProducts.TabStop = false;
            grpBoxSelledProducts.Text = "Satılan Ürün Adedi";
            // 
            // lblTotalSoldProductNumber
            // 
            lblTotalSoldProductNumber.AutoSize = true;
            lblTotalSoldProductNumber.Location = new Point(76, 42);
            lblTotalSoldProductNumber.Name = "lblTotalSoldProductNumber";
            lblTotalSoldProductNumber.Size = new Size(0, 15);
            lblTotalSoldProductNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Alınan Tüm Siparişler";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(label1);
            Controls.Add(grpBoxTotalOrder);
            Controls.Add(grpBoxExtraProductGaining);
            Controls.Add(grpBoxSelledProducts);
            Controls.Add(grpBoxCiro);
            Controls.Add(lstTotalOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TumSiparisler";
            Text = "TumSiparisler";
            Load += TumSiparisler_Load;
            grpBoxCiro.ResumeLayout(false);
            grpBoxCiro.PerformLayout();
            grpBoxTotalOrder.ResumeLayout(false);
            grpBoxTotalOrder.PerformLayout();
            grpBoxExtraProductGaining.ResumeLayout(false);
            grpBoxExtraProductGaining.PerformLayout();
            grpBoxSelledProducts.ResumeLayout(false);
            grpBoxSelledProducts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTotalOrders;
        private GroupBox grpBoxCiro;
        private Label lblTotalEndorsement;
        private GroupBox grpBoxTotalOrder;
        private Label lblTotalOrderNumber;
        private GroupBox grpBoxExtraProductGaining;
        private Label lblExtraProductIncome;
        private GroupBox grpBoxSelledProducts;
        private Label lblTotalSoldProductNumber;
        private Label label1;
    }
}