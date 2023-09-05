namespace Webp_to_PNG
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
            lb1 = new ListBox();
            btComecar = new Button();
            btLimpar = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AllowDrop = true;
            lb1.BorderStyle = BorderStyle.None;
            lb1.ForeColor = Color.WhiteSmoke;
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(33, 19);
            lb1.Name = "lb1";
            lb1.Size = new Size(351, 270);
            lb1.TabIndex = 0;
            lb1.DragDrop += lb1_DragDrop;
            lb1.DragEnter += lb1_DragEnter;
            lb1.KeyUp += lb1_KeyUp;
            // 
            // btComecar
            // 
            btComecar.Location = new Point(121, 312);
            btComecar.Name = "btComecar";
            btComecar.Size = new Size(75, 23);
            btComecar.TabIndex = 1;
            btComecar.Text = "Começar";
            btComecar.UseVisualStyleBackColor = true;
            btComecar.Click += btComecar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(230, 312);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 2;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 345);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(351, 23);
            progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 380);
            Controls.Add(progressBar1);
            Controls.Add(btLimpar);
            Controls.Add(btComecar);
            Controls.Add(lb1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            ShowIcon = false;
            Text = "Webp to PNG";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb1;
        private Button btComecar;
        private Button btLimpar;
        private ProgressBar progressBar1;
    }
}