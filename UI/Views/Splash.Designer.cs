namespace UI.Views;

partial class Splash
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Variable Display", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label1.Location = new Point(112, 52);
        label1.Name = "label1";
        label1.Size = new Size(191, 85);
        label1.TabIndex = 0;
        label1.Text = "Redo";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Variable Display", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label2.Location = new Point(327, 52);
        label2.Name = "label2";
        label2.Size = new Size(194, 85);
        label2.TabIndex = 1;
        label2.Text = "From";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Variable Display", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label3.Location = new Point(554, 52);
        label3.Name = "label3";
        label3.Size = new Size(186, 85);
        label3.TabIndex = 2;
        label3.Text = "Start";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Variable Display", 20F, FontStyle.Underline, GraphicsUnit.Point);
        label4.Location = new Point(490, 268);
        label4.Name = "label4";
        label4.Size = new Size(314, 53);
        label4.TabIndex = 3;
        label4.Text = "... Punto e a capo";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // SplashScreen
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSeaGreen;
        ClientSize = new Size(853, 361);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI Variable Display", 11F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "SplashScreen";
        Text = "SplashScreen";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
}