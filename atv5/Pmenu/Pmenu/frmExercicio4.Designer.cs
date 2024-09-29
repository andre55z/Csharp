namespace Pmenu
{
    partial class frmExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(324, 123);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(455, 142);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.Location = new System.Drawing.Point(246, 321);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(165, 91);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Ver Números";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEspaco
            // 
            this.btnEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaco.Location = new System.Drawing.Point(455, 320);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(165, 92);
            this.btnEspaco.TabIndex = 2;
            this.btnEspaco.Text = "primeiro espaço em branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetras.Location = new System.Drawing.Point(665, 320);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(165, 91);
            this.btnLetras.TabIndex = 3;
            this.btnLetras.Text = "Quantas letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 657);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnLetras;
    }
}