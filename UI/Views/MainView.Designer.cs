namespace UI.Views;

partial class MainView
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
        tableLayoutPanel1 = new TableLayoutPanel();
        MenuStrip = new ToolStrip();
        statusStrip1 = new StatusStrip();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2993965F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7006F));
        tableLayoutPanel1.Controls.Add(MenuStrip, 0, 0);
        tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.Size = new Size(1496, 887);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // MenuStrip
        // 
        tableLayoutPanel1.SetColumnSpan(MenuStrip, 3);
        MenuStrip.Dock = DockStyle.Fill;
        MenuStrip.ImageScalingSize = new Size(24, 24);
        MenuStrip.Location = new Point(0, 0);
        MenuStrip.Name = "MenuStrip";
        MenuStrip.Size = new Size(1496, 40);
        MenuStrip.TabIndex = 0;
        MenuStrip.Text = "toolStrip1";
        // 
        // statusStrip1
        // 
        tableLayoutPanel1.SetColumnSpan(statusStrip1, 3);
        statusStrip1.Dock = DockStyle.Fill;
        statusStrip1.ImageScalingSize = new Size(24, 24);
        statusStrip1.Location = new Point(0, 847);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1496, 40);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(11F, 27F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1496, 887);
        Controls.Add(tableLayoutPanel1);
        Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "MainView";
        Text = "MainForm";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ToolStrip MenuStrip;
    private StatusStrip statusStrip1;
}