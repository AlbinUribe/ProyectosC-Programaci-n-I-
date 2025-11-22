namespace Proyecto7C_
{
    partial class currencyConvert
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
            Converter = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // Converter
            // 
            Converter.BackColor = Color.DarkTurquoise;
            Converter.Font = new Font("Old English Text MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Converter.Location = new Point(12, 0);
            Converter.Name = "Converter";
            Converter.Size = new Size(776, 101);
            Converter.TabIndex = 0;
            Converter.Text = "Convertir";
            Converter.UseVisualStyleBackColor = false;
            Converter.Click += Converter_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 107);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 331);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // currencyConvert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(Converter);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "currencyConvert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertidor de Moneda";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Converter;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
