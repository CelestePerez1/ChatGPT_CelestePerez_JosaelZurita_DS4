namespace ChatGPT_CelestePerez_JosaelZurita
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
            lblTitulo = new Label();
            textChat = new TextBox();
            textPrompt = new TextBox();
            label1 = new Label();
            btnEnviar = new Button();
            btnCls = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(259, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(314, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ChatGPT – Cliente WinForms”";
            // 
            // textChat
            // 
            textChat.Location = new Point(12, 60);
            textChat.Multiline = true;
            textChat.Name = "textChat";
            textChat.ReadOnly = true;
            textChat.ScrollBars = ScrollBars.Vertical;
            textChat.Size = new Size(765, 289);
            textChat.TabIndex = 1;
            // 
            // textPrompt
            // 
            textPrompt.Location = new Point(112, 381);
            textPrompt.Multiline = true;
            textPrompt.Name = "textPrompt";
            textPrompt.ScrollBars = ScrollBars.Vertical;
            textPrompt.Size = new Size(665, 48);
            textPrompt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(703, 355);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 3;
            label1.Text = "...";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 401);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCls
            // 
            btnCls.Location = new Point(12, 355);
            btnCls.Name = "btnCls";
            btnCls.Size = new Size(94, 29);
            btnCls.TabIndex = 5;
            btnCls.Text = "Limpiar";
            btnCls.UseVisualStyleBackColor = true;
            btnCls.Click += btnCls_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCls);
            Controls.Add(btnEnviar);
            Controls.Add(label1);
            Controls.Add(textPrompt);
            Controls.Add(textChat);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "ChatGTP";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox textChat;
        private TextBox textPrompt;
        private Label label1;
        private Button btnEnviar;
        private Button btnCls;
    }
}
