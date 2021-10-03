
namespace BobsCNC_Speeds_and_Feeds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBoxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxUnits = new System.Windows.Forms.ComboBox();
            this.labelUnits = new System.Windows.Forms.Label();
            this.LabelRouterName = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSFM = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.TBSurfaceSpeed = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDOCUnit = new System.Windows.Forms.Label();
            this.labelDOC = new System.Windows.Forms.Label();
            this.labelSOUnit = new System.Windows.Forms.Label();
            this.labelSO = new System.Windows.Forms.Label();
            this.labelPRUnit = new System.Windows.Forms.Label();
            this.labelPR = new System.Windows.Forms.Label();
            this.labelFRUnit = new System.Windows.Forms.Label();
            this.labelFR = new System.Windows.Forms.Label();
            this.labelDial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBoxDetails = new System.Windows.Forms.TextBox();
            this.TBoxRPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBoxChipLoad = new System.Windows.Forms.TextBox();
            this.labelChipLoad = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBoxUnitConvert = new System.Windows.Forms.TextBox();
            this.TBoxSFMConvert = new System.Windows.Forms.TextBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CBoxBitDiameter = new System.Windows.Forms.ComboBox();
            this.CBoxFluteCount = new System.Windows.Forms.ComboBox();
            this.TBoxFactor = new System.Windows.Forms.TextBox();
            this.TBoxRPMratio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxModel
            // 
            this.CBoxModel.DisplayMember = "(none)";
            this.CBoxModel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBoxModel.FormattingEnabled = true;
            this.CBoxModel.Items.AddRange(new object[] {
            "E Series",
            "Evolution Series - Makita",
            "Evolution Series - DeWalt",
            "KL7 Series - Makita",
            "KL7 Series - DeWalt",
            "Revolution",
            "Other"});
            this.CBoxModel.Location = new System.Drawing.Point(175, 206);
            this.CBoxModel.Name = "CBoxModel";
            this.CBoxModel.Size = new System.Drawing.Size(236, 29);
            this.CBoxModel.TabIndex = 0;
            this.CBoxModel.Text = "Evolution Series - Makita";
            this.CBoxModel.SelectedIndexChanged += new System.EventHandler(this.CBoxModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(75, 209);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNC Model:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(95, 252);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBoxMaterial
            // 
            this.CBoxMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBoxMaterial.FormattingEnabled = true;
            this.CBoxMaterial.Items.AddRange(new object[] {
            "Aluminum",
            "Acrylic (hard)",
            "Acetal (soft)",
            "Foam Board",
            "Hardwood",
            "MDF",
            "Plywood",
            "Softwood"});
            this.CBoxMaterial.Location = new System.Drawing.Point(175, 249);
            this.CBoxMaterial.Name = "CBoxMaterial";
            this.CBoxMaterial.Size = new System.Drawing.Size(236, 29);
            this.CBoxMaterial.TabIndex = 1;
            this.CBoxMaterial.Text = "Hardwood";
            this.CBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.CBoxMaterial_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(63, 340);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit Diameter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(118, 296);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Units:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CBoxUnits
            // 
            this.CBoxUnits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBoxUnits.FormattingEnabled = true;
            this.CBoxUnits.Items.AddRange(new object[] {
            "Inches",
            "mm"});
            this.CBoxUnits.Location = new System.Drawing.Point(175, 293);
            this.CBoxUnits.Name = "CBoxUnits";
            this.CBoxUnits.Size = new System.Drawing.Size(72, 29);
            this.CBoxUnits.TabIndex = 2;
            this.CBoxUnits.Text = "Inches";
            this.CBoxUnits.SelectedIndexChanged += new System.EventHandler(this.CBoxUnits_SelectedIndexChanged);
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelUnits.Location = new System.Drawing.Point(251, 340);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(57, 21);
            this.labelUnits.TabIndex = 12;
            this.labelUnits.Text = "Inches";
            // 
            // LabelRouterName
            // 
            this.LabelRouterName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRouterName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRouterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.LabelRouterName.Location = new System.Drawing.Point(24, 48);
            this.LabelRouterName.MinimumSize = new System.Drawing.Size(113, 25);
            this.LabelRouterName.Name = "LabelRouterName";
            this.LabelRouterName.Size = new System.Drawing.Size(133, 25);
            this.LabelRouterName.TabIndex = 13;
            this.LabelRouterName.Text = "Makita Dial:";
            this.LabelRouterName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelRouterName.UseMnemonic = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelB.Location = new System.Drawing.Point(60, 73);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(97, 25);
            this.labelB.TabIndex = 14;
            this.labelB.Text = "Feed rate:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelC.Location = new System.Drawing.Point(42, 98);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(115, 25);
            this.labelC.TabIndex = 15;
            this.labelC.Text = "Plunge rate:";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelD.Location = new System.Drawing.Point(59, 123);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(98, 25);
            this.labelD.TabIndex = 16;
            this.labelD.Text = "Step over:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelE.Location = new System.Drawing.Point(12, 148);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(145, 25);
            this.labelE.TabIndex = 17;
            this.labelE.Text = "Depth per pass:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label9.Location = new System.Drawing.Point(586, 707);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Surface Speed:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSFM
            // 
            this.labelSFM.AutoSize = true;
            this.labelSFM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSFM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelSFM.Location = new System.Drawing.Point(799, 702);
            this.labelSFM.Name = "labelSFM";
            this.labelSFM.Size = new System.Drawing.Size(106, 21);
            this.labelSFM.TabIndex = 22;
            this.labelSFM.Text = "feet / minute";
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelWarning.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(33, 425);
            this.labelWarning.MaximumSize = new System.Drawing.Size(450, 120);
            this.labelWarning.MinimumSize = new System.Drawing.Size(450, 120);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(450, 120);
            this.labelWarning.TabIndex = 23;
            // 
            // TBSurfaceSpeed
            // 
            this.TBSurfaceSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBSurfaceSpeed.Location = new System.Drawing.Point(721, 699);
            this.TBSurfaceSpeed.Name = "TBSurfaceSpeed";
            this.TBSurfaceSpeed.ReadOnly = true;
            this.TBSurfaceSpeed.Size = new System.Drawing.Size(72, 29);
            this.TBSurfaceSpeed.TabIndex = 24;
            this.TBSurfaceSpeed.TabStop = false;
            this.TBSurfaceSpeed.Text = "600";
            this.TBSurfaceSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBSurfaceSpeed.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelDOCUnit);
            this.panel1.Controls.Add(this.labelDOC);
            this.panel1.Controls.Add(this.labelSOUnit);
            this.panel1.Controls.Add(this.labelSO);
            this.panel1.Controls.Add(this.labelPRUnit);
            this.panel1.Controls.Add(this.labelPR);
            this.panel1.Controls.Add(this.labelFRUnit);
            this.panel1.Controls.Add(this.labelFR);
            this.panel1.Controls.Add(this.labelDial);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelE);
            this.panel1.Controls.Add(this.labelC);
            this.panel1.Controls.Add(this.LabelRouterName);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelD);
            this.panel1.Location = new System.Drawing.Point(28, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 191);
            this.panel1.TabIndex = 25;
            // 
            // labelDOCUnit
            // 
            this.labelDOCUnit.AutoSize = true;
            this.labelDOCUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDOCUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelDOCUnit.Location = new System.Drawing.Point(221, 148);
            this.labelDOCUnit.Name = "labelDOCUnit";
            this.labelDOCUnit.Size = new System.Drawing.Size(66, 25);
            this.labelDOCUnit.TabIndex = 27;
            this.labelDOCUnit.Text = "inches";
            this.labelDOCUnit.UseMnemonic = false;
            // 
            // labelDOC
            // 
            this.labelDOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOC.AutoSize = true;
            this.labelDOC.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelDOC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDOC.Location = new System.Drawing.Point(159, 148);
            this.labelDOC.MinimumSize = new System.Drawing.Size(58, 25);
            this.labelDOC.Name = "labelDOC";
            this.labelDOC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDOC.Size = new System.Drawing.Size(58, 25);
            this.labelDOC.TabIndex = 26;
            this.labelDOC.Text = "0.010";
            this.labelDOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDOC.UseMnemonic = false;
            // 
            // labelSOUnit
            // 
            this.labelSOUnit.AutoSize = true;
            this.labelSOUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSOUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelSOUnit.Location = new System.Drawing.Point(221, 123);
            this.labelSOUnit.Name = "labelSOUnit";
            this.labelSOUnit.Size = new System.Drawing.Size(66, 25);
            this.labelSOUnit.TabIndex = 25;
            this.labelSOUnit.Text = "inches";
            this.labelSOUnit.UseMnemonic = false;
            // 
            // labelSO
            // 
            this.labelSO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSO.AutoSize = true;
            this.labelSO.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelSO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSO.Location = new System.Drawing.Point(159, 123);
            this.labelSO.MinimumSize = new System.Drawing.Size(58, 25);
            this.labelSO.Name = "labelSO";
            this.labelSO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSO.Size = new System.Drawing.Size(58, 25);
            this.labelSO.TabIndex = 24;
            this.labelSO.Text = "0.001";
            this.labelSO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSO.UseMnemonic = false;
            // 
            // labelPRUnit
            // 
            this.labelPRUnit.AutoSize = true;
            this.labelPRUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPRUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelPRUnit.Location = new System.Drawing.Point(221, 98);
            this.labelPRUnit.Name = "labelPRUnit";
            this.labelPRUnit.Size = new System.Drawing.Size(135, 25);
            this.labelPRUnit.TabIndex = 23;
            this.labelPRUnit.Text = "inches/minute";
            this.labelPRUnit.UseMnemonic = false;
            // 
            // labelPR
            // 
            this.labelPR.AllowDrop = true;
            this.labelPR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPR.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelPR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPR.Location = new System.Drawing.Point(163, 98);
            this.labelPR.MinimumSize = new System.Drawing.Size(44, 27);
            this.labelPR.Name = "labelPR";
            this.labelPR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPR.Size = new System.Drawing.Size(56, 27);
            this.labelPR.TabIndex = 22;
            this.labelPR.Text = "100";
            this.labelPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPR.UseMnemonic = false;
            // 
            // labelFRUnit
            // 
            this.labelFRUnit.AutoSize = true;
            this.labelFRUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFRUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelFRUnit.Location = new System.Drawing.Point(221, 73);
            this.labelFRUnit.Name = "labelFRUnit";
            this.labelFRUnit.Size = new System.Drawing.Size(135, 25);
            this.labelFRUnit.TabIndex = 21;
            this.labelFRUnit.Text = "inches/minute";
            this.labelFRUnit.UseMnemonic = false;
            // 
            // labelFR
            // 
            this.labelFR.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelFR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFR.Location = new System.Drawing.Point(163, 73);
            this.labelFR.MinimumSize = new System.Drawing.Size(44, 27);
            this.labelFR.Name = "labelFR";
            this.labelFR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFR.Size = new System.Drawing.Size(56, 27);
            this.labelFR.TabIndex = 20;
            this.labelFR.Text = "100";
            this.labelFR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFR.UseMnemonic = false;
            // 
            // labelDial
            // 
            this.labelDial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDial.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelDial.Location = new System.Drawing.Point(185, 48);
            this.labelDial.MaximumSize = new System.Drawing.Size(40, 25);
            this.labelDial.MinimumSize = new System.Drawing.Size(40, 25);
            this.labelDial.Name = "labelDial";
            this.labelDial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDial.Size = new System.Drawing.Size(40, 25);
            this.labelDial.TabIndex = 19;
            this.labelDial.Text = "1.0";
            this.labelDial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDial.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(-2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Project Settings:";
            // 
            // TBoxDetails
            // 
            this.TBoxDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBoxDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.TBoxDetails.Location = new System.Drawing.Point(540, 22);
            this.TBoxDetails.Multiline = true;
            this.TBoxDetails.Name = "TBoxDetails";
            this.TBoxDetails.ReadOnly = true;
            this.TBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBoxDetails.Size = new System.Drawing.Size(467, 550);
            this.TBoxDetails.TabIndex = 28;
            this.TBoxDetails.TabStop = false;
            // 
            // TBoxRPM
            // 
            this.TBoxRPM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxRPM.Location = new System.Drawing.Point(721, 664);
            this.TBoxRPM.Name = "TBoxRPM";
            this.TBoxRPM.ReadOnly = true;
            this.TBoxRPM.Size = new System.Drawing.Size(72, 29);
            this.TBoxRPM.TabIndex = 8;
            this.TBoxRPM.TabStop = false;
            this.TBoxRPM.Text = "600";
            this.TBoxRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxRPM.WordWrap = false;
            this.TBoxRPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressControl);
            this.TBoxRPM.Validating += new System.ComponentModel.CancelEventHandler(this.ValidRPM);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(799, 667);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "RPM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(586, 672);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Spindle Speed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label10.Location = new System.Drawing.Point(28, 384);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(141, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "Number of Flutes:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxChipLoad
            // 
            this.TBoxChipLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxChipLoad.Location = new System.Drawing.Point(721, 629);
            this.TBoxChipLoad.Name = "TBoxChipLoad";
            this.TBoxChipLoad.ReadOnly = true;
            this.TBoxChipLoad.Size = new System.Drawing.Size(72, 29);
            this.TBoxChipLoad.TabIndex = 7;
            this.TBoxChipLoad.TabStop = false;
            this.TBoxChipLoad.Text = "0.002";
            this.TBoxChipLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBoxChipLoad.WordWrap = false;
            this.TBoxChipLoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressControl);
            this.TBoxChipLoad.Validating += new System.ComponentModel.CancelEventHandler(this.Valid_Chipload);
            // 
            // labelChipLoad
            // 
            this.labelChipLoad.AutoSize = true;
            this.labelChipLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChipLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.labelChipLoad.Location = new System.Drawing.Point(799, 632);
            this.labelChipLoad.Name = "labelChipLoad";
            this.labelChipLoad.Size = new System.Drawing.Size(57, 21);
            this.labelChipLoad.TabIndex = 34;
            this.labelChipLoad.Text = "Inches";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.label12.Location = new System.Drawing.Point(619, 637);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 33;
            this.label12.Text = "Chip Load:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxUnitConvert
            // 
            this.TBoxUnitConvert.Location = new System.Drawing.Point(436, 281);
            this.TBoxUnitConvert.Name = "TBoxUnitConvert";
            this.TBoxUnitConvert.Size = new System.Drawing.Size(42, 23);
            this.TBoxUnitConvert.TabIndex = 36;
            this.TBoxUnitConvert.Text = "1";
            this.TBoxUnitConvert.Visible = false;
            // 
            // TBoxSFMConvert
            // 
            this.TBoxSFMConvert.Location = new System.Drawing.Point(436, 310);
            this.TBoxSFMConvert.Name = "TBoxSFMConvert";
            this.TBoxSFMConvert.Size = new System.Drawing.Size(42, 23);
            this.TBoxSFMConvert.TabIndex = 37;
            this.TBoxSFMConvert.Text = "1";
            this.TBoxSFMConvert.Visible = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(115)))));
            this.CheckBox1.Location = new System.Drawing.Point(586, 589);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(258, 25);
            this.CheckBox1.TabIndex = 6;
            this.CheckBox1.Text = "Override RPM and/or Chip load";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CBoxBitDiameter
            // 
            this.CBoxBitDiameter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBoxBitDiameter.FormattingEnabled = true;
            this.CBoxBitDiameter.Items.AddRange(new object[] {
            "0.031",
            "0.063",
            "0.125",
            "0.250",
            "0.375",
            "0.500",
            "0.625",
            "0.750",
            "1.000",
            "1.250",
            "1.500",
            "2.000"});
            this.CBoxBitDiameter.Location = new System.Drawing.Point(173, 337);
            this.CBoxBitDiameter.Name = "CBoxBitDiameter";
            this.CBoxBitDiameter.Size = new System.Drawing.Size(72, 29);
            this.CBoxBitDiameter.TabIndex = 3;
            this.CBoxBitDiameter.Text = "0.250";
            this.CBoxBitDiameter.SelectedIndexChanged += new System.EventHandler(this.CBoxBitDiameter_SelectedIndexChanged);
            // 
            // CBoxFluteCount
            // 
            this.CBoxFluteCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBoxFluteCount.FormattingEnabled = true;
            this.CBoxFluteCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBoxFluteCount.Location = new System.Drawing.Point(173, 381);
            this.CBoxFluteCount.Name = "CBoxFluteCount";
            this.CBoxFluteCount.Size = new System.Drawing.Size(72, 29);
            this.CBoxFluteCount.TabIndex = 4;
            this.CBoxFluteCount.Text = "2";
            this.CBoxFluteCount.SelectedIndexChanged += new System.EventHandler(this.CBoxFluteCount_SelectedIndexChanged);
            // 
            // TBoxFactor
            // 
            this.TBoxFactor.Location = new System.Drawing.Point(436, 338);
            this.TBoxFactor.Name = "TBoxFactor";
            this.TBoxFactor.Size = new System.Drawing.Size(42, 23);
            this.TBoxFactor.TabIndex = 43;
            this.TBoxFactor.Text = "1";
            this.TBoxFactor.Visible = false;
            // 
            // TBoxRPMratio
            // 
            this.TBoxRPMratio.Location = new System.Drawing.Point(436, 367);
            this.TBoxRPMratio.Name = "TBoxRPMratio";
            this.TBoxRPMratio.Size = new System.Drawing.Size(42, 23);
            this.TBoxRPMratio.TabIndex = 44;
            this.TBoxRPMratio.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 784);
            this.Controls.Add(this.TBoxRPMratio);
            this.Controls.Add(this.TBoxFactor);
            this.Controls.Add(this.CBoxFluteCount);
            this.Controls.Add(this.CBoxBitDiameter);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.TBoxSFMConvert);
            this.Controls.Add(this.TBoxUnitConvert);
            this.Controls.Add(this.TBoxChipLoad);
            this.Controls.Add(this.labelChipLoad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBoxRPM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBoxDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBSurfaceSpeed);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelSFM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBoxUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Speed and Feed Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxUnits;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.Label LabelRouterName;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSFM;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.TextBox TBSurfaceSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDOCUnit;
        private System.Windows.Forms.Label labelDOC;
        private System.Windows.Forms.Label labelSOUnit;
        private System.Windows.Forms.Label labelSO;
        private System.Windows.Forms.Label labelPRUnit;
        private System.Windows.Forms.Label labelPR;
        private System.Windows.Forms.Label labelFRUnit;
        private System.Windows.Forms.Label labelFR;
        private System.Windows.Forms.Label labelDial;
        private System.Windows.Forms.TextBox TBoxDetails;
        private System.Windows.Forms.TextBox TBoxRPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBoxChipLoad;
        private System.Windows.Forms.Label labelChipLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBoxUnitConvert;
        private System.Windows.Forms.TextBox TBoxSFMConvert;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.ComboBox CBoxBitDiameter;
        private System.Windows.Forms.ComboBox CBoxFluteCount;
        private System.Windows.Forms.TextBox TBoxFactor;
        private System.Windows.Forms.TextBox TBoxRPMratio;
    }
}

