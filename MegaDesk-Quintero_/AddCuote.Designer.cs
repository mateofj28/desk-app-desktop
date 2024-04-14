using System.ComponentModel;

namespace MegaDesk_Quintero_
{
    partial class AddCuote
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
            txtCustomerName = new Label();
            txtNumberDrawers = new Label();
            txtDeskDepth = new Label();
            txtDeskWidth = new Label();
            txtRushOrder = new Label();
            txtDesktopMaterial = new Label();
            txtSubmit = new Button();
            tbDeskWidth = new TextBox();
            tbDeskDepth = new TextBox();
            tbCustomerName = new TextBox();
            cbNumberDrawers = new ComboBox();
            cbDesktopMaterial = new ComboBox();
            cbRushOrder = new ComboBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.AutoSize = true;
            txtCustomerName.Location = new Point(46, 34);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(141, 25);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.Text = "Customer Name";
            // 
            // txtNumberDrawers
            // 
            txtNumberDrawers.AutoSize = true;
            txtNumberDrawers.Location = new Point(46, 156);
            txtNumberDrawers.Name = "txtNumberDrawers";
            txtNumberDrawers.Size = new Size(210, 25);
            txtNumberDrawers.TabIndex = 1;
            txtNumberDrawers.Text = "Number of Drawers (0-7)";
            // 
            // txtDeskDepth
            // 
            txtDeskDepth.AutoSize = true;
            txtDeskDepth.Location = new Point(46, 115);
            txtDeskDepth.Name = "txtDeskDepth";
            txtDeskDepth.Size = new Size(221, 25);
            txtDeskDepth.TabIndex = 2;
            txtDeskDepth.Text = "Desk Depth (12-48 inches)";
            // 
            // txtDeskWidth
            // 
            txtDeskWidth.AutoSize = true;
            txtDeskWidth.Location = new Point(46, 75);
            txtDeskWidth.Name = "txtDeskWidth";
            txtDeskWidth.Size = new Size(220, 25);
            txtDeskWidth.TabIndex = 3;
            txtDeskWidth.Text = "Desk Width (24-96 inches)";
            // 
            // txtRushOrder
            // 
            txtRushOrder.AutoSize = true;
            txtRushOrder.Location = new Point(46, 242);
            txtRushOrder.Name = "txtRushOrder";
            txtRushOrder.Size = new Size(178, 25);
            txtRushOrder.TabIndex = 4;
            txtRushOrder.Text = "Rush Order Selection";
            // 
            // txtDesktopMaterial
            // 
            txtDesktopMaterial.AutoSize = true;
            txtDesktopMaterial.Location = new Point(46, 199);
            txtDesktopMaterial.Name = "txtDesktopMaterial";
            txtDesktopMaterial.Size = new Size(147, 25);
            txtDesktopMaterial.TabIndex = 5;
            txtDesktopMaterial.Text = "Desktop Material";
            // 
            // txtSubmit
            // 
            txtSubmit.Location = new Point(46, 300);
            txtSubmit.Name = "txtSubmit";
            txtSubmit.Size = new Size(433, 34);
            txtSubmit.TabIndex = 6;
            txtSubmit.Text = "Submit";
            txtSubmit.UseVisualStyleBackColor = true;
            txtSubmit.Click += txtSubmit_Click;
            // 
            // tbDeskWidth
            // 
            tbDeskWidth.Location = new Point(293, 72);
            tbDeskWidth.Name = "tbDeskWidth";
            tbDeskWidth.Size = new Size(186, 31);
            tbDeskWidth.TabIndex = 7;
            tbDeskWidth.TextChanged += TbDeskWidth_TextChanged;
            tbDeskWidth.KeyPress += tbDeskWidth_KeyPress;
            // 
            // tbDeskDepth
            // 
            tbDeskDepth.Location = new Point(293, 112);
            tbDeskDepth.Name = "tbDeskDepth";
            tbDeskDepth.Size = new Size(186, 31);
            tbDeskDepth.TabIndex = 8;
            tbDeskDepth.TextChanged += tbDeskDepth_TextChanged;
            tbDeskDepth.KeyPress += tbDeskDepth_KeyPress;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(293, 28);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(186, 31);
            tbCustomerName.TabIndex = 9;
            tbCustomerName.TextChanged += tbCustomerName_TextChanged;
            tbCustomerName.KeyPress += tbCustomerName_KeyPress;
            // 
            // cbNumberDrawers
            // 
            cbNumberDrawers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumberDrawers.FormattingEnabled = true;
            cbNumberDrawers.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbNumberDrawers.Location = new Point(293, 156);
            cbNumberDrawers.Name = "cbNumberDrawers";
            cbNumberDrawers.Size = new Size(186, 33);
            cbNumberDrawers.TabIndex = 10;
            // 
            // cbDesktopMaterial
            // 
            cbDesktopMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDesktopMaterial.FormattingEnabled = true;
            cbDesktopMaterial.Items.AddRange(new object[] { "Oak", "Laminate", "Pine", "Rosewood", "Veneer" });
            cbDesktopMaterial.Location = new Point(293, 199);
            cbDesktopMaterial.Name = "cbDesktopMaterial";
            cbDesktopMaterial.Size = new Size(186, 33);
            cbDesktopMaterial.TabIndex = 11;
            // 
            // cbRushOrder
            // 
            cbRushOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRushOrder.FormattingEnabled = true;
            cbRushOrder.Items.AddRange(new object[] { "none", "3 Days", "5 Days", "7 Days" });
            cbRushOrder.Location = new Point(293, 242);
            cbRushOrder.Name = "cbRushOrder";
            cbRushOrder.Size = new Size(186, 33);
            cbRushOrder.TabIndex = 12;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(676, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += Button1_Click;
            // 
            // AddCuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(cbRushOrder);
            Controls.Add(cbDesktopMaterial);
            Controls.Add(cbNumberDrawers);
            Controls.Add(tbCustomerName);
            Controls.Add(tbDeskDepth);
            Controls.Add(tbDeskWidth);
            Controls.Add(txtSubmit);
            Controls.Add(txtDesktopMaterial);
            Controls.Add(txtRushOrder);
            Controls.Add(txtDeskWidth);
            Controls.Add(txtDeskDepth);
            Controls.Add(txtNumberDrawers);
            Controls.Add(txtCustomerName);
            Name = "AddCuote";
            Text = "AddCuote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCustomerName;
        private Label txtNumberDrawers;
        private Label txtDeskDepth;
        private Label txtDeskWidth;
        private Label txtRushOrder;
        private Label txtDesktopMaterial;
        private Button txtSubmit;
        private TextBox tbDeskWidth;
        private TextBox tbDeskDepth;
        private TextBox tbCustomerName;
        private ComboBox cbNumberDrawers;
        private ComboBox cbDesktopMaterial;
        private ComboBox cbRushOrder;
        private Button btnClose;
    }
}