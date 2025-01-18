namespace laba10v2
{
    partial class Form1
    {
        /// <summary>
        /// Требуемый переменный элемент дизайна.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если используется управляемый ресурс; в противном случае — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм

        /// <summary>
        /// Требуемый метод для поддержки корректной конструкцией
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Location = new System.Drawing.Point(12, 12);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapes.TabIndex = 0;
            this.comboBoxShapes.SelectedIndexChanged += new System.EventHandler(this.comboBoxShapes_SelectedIndexChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(139, 10);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.Window;
            this.panelDraw.Location = new System.Drawing.Point(12, 39);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(776, 399);
            this.panelDraw.TabIndex = 2;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.comboBoxShapes);
            this.Name = "Form1";
            this.Text = "Drawing App";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelDraw;
    }
}