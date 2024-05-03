using GenderSampleApp.Components;
using GenderSampleApp.Controls;

namespace GenderSampleApp;

partial class RadioButtonForm
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
        GenderRadioGroupBox = new RadioGroupBox();
        OtherRadioButton = new RadioButton();
        MaleRadioButton = new RadioButton();
        FemaleRadioButton = new RadioButton();
        FirstNameTextBox = new TextBox();
        coreBindingNavigator1 = new CoreBindingNavigator();
        SaveButton = new Button();
        LastNameTextBox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        PrimaryKeyLabel = new Label();
        label3 = new Label();
        GenderRadioGroupBox.SuspendLayout();
        coreBindingNavigator1.BeginInit();
        SuspendLayout();
        // 
        // GenderRadioGroupBox
        // 
        GenderRadioGroupBox.Controls.Add(OtherRadioButton);
        GenderRadioGroupBox.Controls.Add(MaleRadioButton);
        GenderRadioGroupBox.Controls.Add(FemaleRadioButton);
        GenderRadioGroupBox.Location = new Point(37, 62);
        GenderRadioGroupBox.Name = "GenderRadioGroupBox";
        GenderRadioGroupBox.Selected = 0;
        GenderRadioGroupBox.Size = new Size(250, 158);
        GenderRadioGroupBox.TabIndex = 0;
        GenderRadioGroupBox.TabStop = false;
        GenderRadioGroupBox.Text = "Gender";
        // 
        // OtherRadioButton
        // 
        OtherRadioButton.AutoSize = true;
        OtherRadioButton.Location = new Point(18, 94);
        OtherRadioButton.Name = "OtherRadioButton";
        OtherRadioButton.Size = new Size(67, 24);
        OtherRadioButton.TabIndex = 2;
        OtherRadioButton.TabStop = true;
        OtherRadioButton.Text = "Other";
        OtherRadioButton.UseVisualStyleBackColor = true;
        // 
        // MaleRadioButton
        // 
        MaleRadioButton.AutoSize = true;
        MaleRadioButton.Location = new Point(18, 64);
        MaleRadioButton.Name = "MaleRadioButton";
        MaleRadioButton.Size = new Size(63, 24);
        MaleRadioButton.TabIndex = 1;
        MaleRadioButton.TabStop = true;
        MaleRadioButton.Text = "Male";
        MaleRadioButton.UseVisualStyleBackColor = true;
        // 
        // FemaleRadioButton
        // 
        FemaleRadioButton.AutoSize = true;
        FemaleRadioButton.Location = new Point(18, 34);
        FemaleRadioButton.Name = "FemaleRadioButton";
        FemaleRadioButton.Size = new Size(78, 24);
        FemaleRadioButton.TabIndex = 0;
        FemaleRadioButton.TabStop = true;
        FemaleRadioButton.Text = "Female";
        FemaleRadioButton.UseVisualStyleBackColor = true;
        // 
        // FirstNameTextBox
        // 
        FirstNameTextBox.Location = new Point(311, 134);
        FirstNameTextBox.Name = "FirstNameTextBox";
        FirstNameTextBox.Size = new Size(230, 27);
        FirstNameTextBox.TabIndex = 1;
        // 
        // coreBindingNavigator1
        // 
        coreBindingNavigator1.ImageScalingSize = new Size(20, 20);
        coreBindingNavigator1.Location = new Point(0, 0);
        coreBindingNavigator1.Name = "coreBindingNavigator1";
        coreBindingNavigator1.Size = new Size(674, 27);
        coreBindingNavigator1.TabIndex = 2;
        coreBindingNavigator1.Text = "coreBindingNavigator1";
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(39, 239);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(248, 29);
        SaveButton.TabIndex = 3;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // LastNameTextBox
        // 
        LastNameTextBox.Location = new Point(311, 195);
        LastNameTextBox.Name = "LastNameTextBox";
        LastNameTextBox.Size = new Size(230, 27);
        LastNameTextBox.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(310, 111);
        label1.Name = "label1";
        label1.Size = new Size(36, 20);
        label1.TabIndex = 5;
        label1.Text = "First";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(311, 172);
        label2.Name = "label2";
        label2.Size = new Size(35, 20);
        label2.TabIndex = 6;
        label2.Text = "Last";
        // 
        // PrimaryKeyLabel
        // 
        PrimaryKeyLabel.AutoSize = true;
        PrimaryKeyLabel.Location = new Point(348, 73);
        PrimaryKeyLabel.Name = "PrimaryKeyLabel";
        PrimaryKeyLabel.Size = new Size(124, 20);
        PrimaryKeyLabel.TabIndex = 7;
        PrimaryKeyLabel.Text = "Primary key value";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(311, 73);
        label3.Name = "label3";
        label3.Size = new Size(22, 20);
        label3.TabIndex = 8;
        label3.Text = "Id";
        // 
        // RadioButtonForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(674, 297);
        Controls.Add(label3);
        Controls.Add(PrimaryKeyLabel);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(LastNameTextBox);
        Controls.Add(SaveButton);
        Controls.Add(coreBindingNavigator1);
        Controls.Add(FirstNameTextBox);
        Controls.Add(GenderRadioGroupBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "RadioButtonForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Binding data - showcase radio buttons";
        GenderRadioGroupBox.ResumeLayout(false);
        GenderRadioGroupBox.PerformLayout();
        coreBindingNavigator1.EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RadioGroupBox GenderRadioGroupBox;
    private RadioButton FemaleRadioButton;
    private RadioButton OtherRadioButton;
    private RadioButton MaleRadioButton;
    private TextBox FirstNameTextBox;
    private CoreBindingNavigator coreBindingNavigator1;
    private Button SaveButton;
    private TextBox LastNameTextBox;
    private Label label1;
    private Label label2;
    private Label PrimaryKeyLabel;
    private Label label3;
}