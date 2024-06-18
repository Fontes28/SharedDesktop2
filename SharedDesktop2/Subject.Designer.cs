
namespace SharedDesktop2
{
    partial class Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.siticoneRoundedComboBox1 = new Siticone.UI.WinForms.SiticoneRoundedComboBox();
            this.siticoneMaterialTextBox2 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneRoundedTextBox1 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.siticoneGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cad. Tema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Atualizar Temas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.siticoneRoundedButton1);
            this.siticoneGroupBox1.Controls.Add(this.siticoneRoundedTextBox1);
            this.siticoneGroupBox1.Controls.Add(this.siticoneMaterialTextBox2);
            this.siticoneGroupBox1.Controls.Add(this.siticoneRoundedComboBox1);
            this.siticoneGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(749, 453);
            this.siticoneGroupBox1.TabIndex = 0;
            this.siticoneGroupBox1.Text = "Cadastrar Disciplina";
            // 
            // siticoneRoundedComboBox1
            // 
            this.siticoneRoundedComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneRoundedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneRoundedComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneRoundedComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneRoundedComboBox1.FormattingEnabled = true;
            this.siticoneRoundedComboBox1.HoveredState.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.ItemHeight = 30;
            this.siticoneRoundedComboBox1.Items.AddRange(new object[] {
            "Exatas",
            "Humanas e Linguagens",
            "Ciências da Natureza",
            "Insfraestrutura e Tecnologia",
            "Saúde",
            "Gestão e Processos Industriais"});
            this.siticoneRoundedComboBox1.ItemsAppearance.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.Location = new System.Drawing.Point(94, 163);
            this.siticoneRoundedComboBox1.Name = "siticoneRoundedComboBox1";
            this.siticoneRoundedComboBox1.ShadowDecoration.Parent = this.siticoneRoundedComboBox1;
            this.siticoneRoundedComboBox1.Size = new System.Drawing.Size(394, 36);
            this.siticoneRoundedComboBox1.TabIndex = 1;
            // 
            // siticoneMaterialTextBox2
            // 
            this.siticoneMaterialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneMaterialTextBox2.DefaultText = "";
            this.siticoneMaterialTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox2.DisabledState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox2.FocusedState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox2.HoveredState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.Location = new System.Drawing.Point(94, 247);
            this.siticoneMaterialTextBox2.Name = "siticoneMaterialTextBox2";
            this.siticoneMaterialTextBox2.PasswordChar = '\0';
            this.siticoneMaterialTextBox2.PlaceholderText = "";
            this.siticoneMaterialTextBox2.SelectedText = "";
            this.siticoneMaterialTextBox2.ShadowDecoration.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.Size = new System.Drawing.Size(394, 42);
            this.siticoneMaterialTextBox2.TabIndex = 2;
            // 
            // siticoneRoundedTextBox1
            // 
            this.siticoneRoundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneRoundedTextBox1.DefaultText = "";
            this.siticoneRoundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.DisabledState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.FocusedState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.HoveredState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Location = new System.Drawing.Point(94, 88);
            this.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1";
            this.siticoneRoundedTextBox1.PasswordChar = '\0';
            this.siticoneRoundedTextBox1.PlaceholderText = "";
            this.siticoneRoundedTextBox1.SelectedText = "";
            this.siticoneRoundedTextBox1.ShadowDecoration.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Size = new System.Drawing.Size(200, 36);
            this.siticoneRoundedTextBox1.TabIndex = 3;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(94, 332);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(310, 45);
            this.siticoneRoundedButton1.TabIndex = 4;
            this.siticoneRoundedButton1.Text = "siticoneRoundedButton1";
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Subject";
            this.Text = "Disciplina";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox siticoneRoundedTextBox1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox2;
        private Siticone.UI.WinForms.SiticoneRoundedComboBox siticoneRoundedComboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}