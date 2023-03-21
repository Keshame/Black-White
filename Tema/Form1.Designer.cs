namespace Tema
{
    partial class Tema_Form
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
            this.components = new System.ComponentModel.Container();
            this.Drag_Panel = new System.Windows.Forms.Panel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Tema_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this._Panel = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Drag_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drag_Panel
            // 
            this.Drag_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Drag_Panel.Controls.Add(this.guna2ControlBox1);
            this.Drag_Panel.Controls.Add(this.Tema_Switch);
            this.Drag_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drag_Panel.Location = new System.Drawing.Point(0, 0);
            this.Drag_Panel.Name = "Drag_Panel";
            this.Drag_Panel.Size = new System.Drawing.Size(800, 32);
            this.Drag_Panel.TabIndex = 0;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.Drag_Panel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // Tema_Switch
            // 
            this.Tema_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tema_Switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tema_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Tema_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Tema_Switch.Location = new System.Drawing.Point(12, 6);
            this.Tema_Switch.Name = "Tema_Switch";
            this.Tema_Switch.Size = new System.Drawing.Size(35, 20);
            this.Tema_Switch.TabIndex = 0;
            this.Tema_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tema_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Tema_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Tema_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Tema_Switch.CheckedChanged += new System.EventHandler(this.TemaSwitch_CheckedChanged);
            // 
            // _Panel
            // 
            this._Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Panel.Location = new System.Drawing.Point(0, 32);
            this._Panel.Name = "_Panel";
            this._Panel.Size = new System.Drawing.Size(800, 418);
            this._Panel.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(755, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox1.TabIndex = 2;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Tema_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._Panel);
            this.Controls.Add(this.Drag_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tema_Form";
            this.Text = "Form1";
            this.TopMost = true;
            this.Drag_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drag_Panel;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Tema_Switch;
        private System.Windows.Forms.Panel _Panel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

