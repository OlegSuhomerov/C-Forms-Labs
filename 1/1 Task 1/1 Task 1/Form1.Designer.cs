namespace _1_Task_1
{
    partial class formEleps
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCloseForm.BackColor = System.Drawing.Color.Red;
            this.buttonCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCloseForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseForm.Font = new System.Drawing.Font("Elephant", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCloseForm.Location = new System.Drawing.Point(324, 169);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(100, 50);
            this.buttonCloseForm.TabIndex = 0;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // formEleps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.buttonCloseForm);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEleps";
            this.Text = "Eleps";
            this.Load += new System.EventHandler(this.formEleps_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
    }
}

