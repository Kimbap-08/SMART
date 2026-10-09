using System.ComponentModel;
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SMART
{
    public partial class Courses : UserControl
    {
    #region Windows Form Designer generated code
    private System.Windows.Forms.Label designerControl1 = null!;
    private System.Windows.Forms.Label designerControl2 = null!;
    private System.Windows.Forms.Panel designerControl3 = null!;
    private System.Windows.Forms.Label designerControl4 = null!;
    private System.Windows.Forms.TextBox txtCode = null!;
    private System.Windows.Forms.Label designerControl6 = null!;
    private System.Windows.Forms.TextBox txtName = null!;
    private System.Windows.Forms.Label designerControl8 = null!;
    private System.Windows.Forms.TextBox txtSection = null!;
    private System.Windows.Forms.Label designerControl10 = null!;
    private System.Windows.Forms.TextBox txtEnrollCode = null!;
    private System.Windows.Forms.Label designerControl12 = null!;
    private System.Windows.Forms.ComboBox cboProgram = null!;
    private System.Windows.Forms.Label designerControl14 = null!;
    private System.Windows.Forms.ComboBox cboInstructor = null!;
    private System.Windows.Forms.Button btnSave = null!;
    private System.Windows.Forms.Button btnCancel = null!;
    private System.Windows.Forms.Label lblFormTitle = null!;
    private System.Windows.Forms.Label lblMsg = null!;
    private System.Windows.Forms.Label lblTotal = null!;
    private System.Windows.Forms.DataGridView grid = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn0 = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn1 = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn2 = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn3 = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn4 = null!;
    private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn5 = null!;

    private void InitializeComponent()
    {
            designerControl1 = new System.Windows.Forms.Label();
            designerControl2 = new System.Windows.Forms.Label();
            designerControl3 = new System.Windows.Forms.Panel();
            designerControl4 = new System.Windows.Forms.Label();
            txtCode = new System.Windows.Forms.TextBox();
            designerControl6 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            designerControl8 = new System.Windows.Forms.Label();
            txtSection = new System.Windows.Forms.TextBox();
            designerControl10 = new System.Windows.Forms.Label();
            txtEnrollCode = new System.Windows.Forms.TextBox();
            designerControl12 = new System.Windows.Forms.Label();
            cboProgram = new System.Windows.Forms.ComboBox();
            designerControl14 = new System.Windows.Forms.Label();
            cboInstructor = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblFormTitle = new System.Windows.Forms.Label();
            lblMsg = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            grid = new System.Windows.Forms.DataGridView();
            gridColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gridColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gridColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gridColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gridColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gridColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var gridColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            var gridAlternatingRowsDefaultCellStyle = new DataGridViewCellStyle();
            var gridDefaultCellStyle = new DataGridViewCellStyle();
            designerControl3.SuspendLayout();
            SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1200, 800);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            this.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            this.AutoScroll = false;
            this.TabIndex = 0;
            this.TabStop = true;
            this.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.ClientSize = new System.Drawing.Size(1200, 800);
            designerControl1.Name = "designerControl1";
            designerControl1.Location = new System.Drawing.Point(20, 20);
            designerControl1.Size = new System.Drawing.Size(277, 42);
            designerControl1.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl1.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl1.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            designerControl1.Font = new System.Drawing.Font("Segoe UI", 20F, (System.Drawing.FontStyle)1);
            designerControl1.AutoSize = true;
            designerControl1.Text = "Course Management";
            designerControl1.TabIndex = 0;
            designerControl1.TabStop = false;
            designerControl1.Enabled = true;
            designerControl1.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl1.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl1.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl1.AutoEllipsis = false;
            designerControl1.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl2.Name = "designerControl2";
            designerControl2.Location = new System.Drawing.Point(22, 58);
            designerControl2.Size = new System.Drawing.Size(351, 23);
            designerControl2.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl2.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl2.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            designerControl2.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl2.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            designerControl2.AutoSize = true;
            designerControl2.Text = "Add courses and assign instructors  —  click a row to edit";
            designerControl2.TabIndex = 1;
            designerControl2.TabStop = false;
            designerControl2.Enabled = true;
            designerControl2.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl2.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl2.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl2.AutoEllipsis = false;
            designerControl2.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl3.Name = "designerControl3";
            designerControl3.Location = new System.Drawing.Point(20, 90);
            designerControl3.Size = new System.Drawing.Size(1100, 190);
            designerControl3.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl3.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            designerControl3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl3.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl3.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
            designerControl3.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl3.AutoSize = false;
            designerControl3.AutoScroll = false;
            designerControl3.Text = "";
            designerControl3.TabIndex = 2;
            designerControl3.TabStop = false;
            designerControl3.Enabled = true;
            designerControl3.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl3.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl4.Name = "designerControl4";
            designerControl4.Location = new System.Drawing.Point(12, 34);
            designerControl4.Size = new System.Drawing.Size(66, 19);
            designerControl4.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl4.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl4.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl4.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl4.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl4.AutoSize = true;
            designerControl4.Text = "Course Code";
            designerControl4.TabIndex = 0;
            designerControl4.TabStop = false;
            designerControl4.Enabled = true;
            designerControl4.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl4.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl4.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl4.AutoEllipsis = false;
            designerControl4.MinimumSize = new System.Drawing.Size(0, 0);
            txtCode.Name = "txtCode";
            txtCode.Location = new System.Drawing.Point(12, 52);
            txtCode.Size = new System.Drawing.Size(140, 25);
            txtCode.Dock = (System.Windows.Forms.DockStyle)0;
            txtCode.Anchor = (System.Windows.Forms.AnchorStyles)5;
            txtCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            txtCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            txtCode.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            txtCode.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            txtCode.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            txtCode.AutoSize = true;
            txtCode.Text = "";
            txtCode.TabIndex = 1;
            txtCode.TabStop = true;
            txtCode.Enabled = true;
            txtCode.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            txtCode.PlaceholderText = "";
            txtCode.Multiline = false;
            txtCode.ReadOnly = false;
            txtCode.MaxLength = 32767;
            txtCode.UseSystemPasswordChar = false;
            txtCode.PasswordChar = (char)0;
            txtCode.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            txtCode.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            txtCode.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl6.Name = "designerControl6";
            designerControl6.Location = new System.Drawing.Point(170, 34);
            designerControl6.Size = new System.Drawing.Size(70, 19);
            designerControl6.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl6.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl6.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl6.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl6.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl6.AutoSize = true;
            designerControl6.Text = "Course Name";
            designerControl6.TabIndex = 2;
            designerControl6.TabStop = false;
            designerControl6.Enabled = true;
            designerControl6.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl6.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl6.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl6.AutoEllipsis = false;
            designerControl6.MinimumSize = new System.Drawing.Size(0, 0);
            txtName.Name = "txtName";
            txtName.Location = new System.Drawing.Point(170, 52);
            txtName.Size = new System.Drawing.Size(260, 25);
            txtName.Dock = (System.Windows.Forms.DockStyle)0;
            txtName.Anchor = (System.Windows.Forms.AnchorStyles)5;
            txtName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            txtName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            txtName.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            txtName.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            txtName.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            txtName.AutoSize = true;
            txtName.Text = "";
            txtName.TabIndex = 3;
            txtName.TabStop = true;
            txtName.Enabled = true;
            txtName.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            txtName.PlaceholderText = "";
            txtName.Multiline = false;
            txtName.ReadOnly = false;
            txtName.MaxLength = 32767;
            txtName.UseSystemPasswordChar = false;
            txtName.PasswordChar = (char)0;
            txtName.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            txtName.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            txtName.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl8.Name = "designerControl8";
            designerControl8.Location = new System.Drawing.Point(448, 34);
            designerControl8.Size = new System.Drawing.Size(40, 19);
            designerControl8.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl8.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl8.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl8.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl8.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl8.AutoSize = true;
            designerControl8.Text = "Section";
            designerControl8.TabIndex = 4;
            designerControl8.TabStop = false;
            designerControl8.Enabled = true;
            designerControl8.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl8.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl8.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl8.AutoEllipsis = false;
            designerControl8.MinimumSize = new System.Drawing.Size(0, 0);
            txtSection.Name = "txtSection";
            txtSection.Location = new System.Drawing.Point(448, 52);
            txtSection.Size = new System.Drawing.Size(140, 25);
            txtSection.Dock = (System.Windows.Forms.DockStyle)0;
            txtSection.Anchor = (System.Windows.Forms.AnchorStyles)5;
            txtSection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            txtSection.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            txtSection.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            txtSection.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            txtSection.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            txtSection.AutoSize = true;
            txtSection.Text = "";
            txtSection.TabIndex = 5;
            txtSection.TabStop = true;
            txtSection.Enabled = true;
            txtSection.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            txtSection.PlaceholderText = "";
            txtSection.Multiline = false;
            txtSection.ReadOnly = false;
            txtSection.MaxLength = 32767;
            txtSection.UseSystemPasswordChar = false;
            txtSection.PasswordChar = (char)0;
            txtSection.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            txtSection.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            txtSection.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl10.Name = "designerControl10";
            designerControl10.Location = new System.Drawing.Point(606, 34);
            designerControl10.Size = new System.Drawing.Size(85, 19);
            designerControl10.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl10.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl10.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl10.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl10.Font = new System.Drawing.Font("Segoe UI", 8F, (System.Drawing.FontStyle)0);
            designerControl10.AutoSize = true;
            designerControl10.Text = "Enrollment Code";
            designerControl10.TabIndex = 6;
            designerControl10.TabStop = false;
            designerControl10.Enabled = true;
            designerControl10.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl10.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl10.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl10.AutoEllipsis = false;
            designerControl10.MinimumSize = new System.Drawing.Size(0, 0);
            txtEnrollCode.Name = "txtEnrollCode";
            txtEnrollCode.Location = new System.Drawing.Point(606, 52);
            txtEnrollCode.Size = new System.Drawing.Size(160, 25);
            txtEnrollCode.Dock = (System.Windows.Forms.DockStyle)0;
            txtEnrollCode.Anchor = (System.Windows.Forms.AnchorStyles)5;
            txtEnrollCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            txtEnrollCode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            txtEnrollCode.BackColor = System.Drawing.Color.FromArgb(255, 26, 26, 46);
            txtEnrollCode.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            txtEnrollCode.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            txtEnrollCode.AutoSize = true;
            txtEnrollCode.Text = "";
            txtEnrollCode.TabIndex = 7;
            txtEnrollCode.TabStop = true;
            txtEnrollCode.Enabled = true;
            txtEnrollCode.BorderStyle = (System.Windows.Forms.BorderStyle)1;
            txtEnrollCode.PlaceholderText = "";
            txtEnrollCode.Multiline = false;
            txtEnrollCode.ReadOnly = false;
            txtEnrollCode.MaxLength = 32767;
            txtEnrollCode.UseSystemPasswordChar = false;
            txtEnrollCode.PasswordChar = (char)0;
            txtEnrollCode.TextAlign = (System.Windows.Forms.HorizontalAlignment)0;
            txtEnrollCode.ScrollBars = (System.Windows.Forms.ScrollBars)0;
            txtEnrollCode.MinimumSize = new System.Drawing.Size(0, 0);
            designerControl12.Name = "designerControl12";
            designerControl12.Location = new System.Drawing.Point(12, 88);
            designerControl12.Size = new System.Drawing.Size(51, 21);
            designerControl12.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl12.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl12.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl12.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl12.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl12.AutoSize = true;
            designerControl12.Text = "Program";
            designerControl12.TabIndex = 8;
            designerControl12.TabStop = false;
            designerControl12.Enabled = true;
            designerControl12.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl12.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl12.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl12.AutoEllipsis = false;
            designerControl12.MinimumSize = new System.Drawing.Size(0, 0);
            cboProgram.Name = "cboProgram";
            cboProgram.Location = new System.Drawing.Point(12, 108);
            cboProgram.Size = new System.Drawing.Size(280, 23);
            cboProgram.Dock = (System.Windows.Forms.DockStyle)0;
            cboProgram.Anchor = (System.Windows.Forms.AnchorStyles)5;
            cboProgram.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            cboProgram.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            cboProgram.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            cboProgram.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            cboProgram.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            cboProgram.AutoSize = false;
            cboProgram.Text = "All Programs";
            cboProgram.TabIndex = 9;
            cboProgram.TabStop = true;
            cboProgram.Enabled = true;
            cboProgram.MaxLength = 0;
            cboProgram.DropDownStyle = (System.Windows.Forms.ComboBoxStyle)2;
            cboProgram.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            cboProgram.IntegralHeight = true;
            cboProgram.MinimumSize = new System.Drawing.Size(0, 0);
            cboProgram.Items.AddRange(new object[] { "All Programs", "BS Computer Engineering", "BS Civil Engineering", "BS Electrical Engineering", "BS Mechanical Engineering", "BS Electronics Engineering", "BS Chemical Engineering", "BS Information Technology", "BS Computer Science", "BS Architecture", "BS Nursing", "BS Education", "BS Business Administration" });
            designerControl14.Name = "designerControl14";
            designerControl14.Location = new System.Drawing.Point(310, 88);
            designerControl14.Size = new System.Drawing.Size(96, 21);
            designerControl14.Dock = (System.Windows.Forms.DockStyle)0;
            designerControl14.Anchor = (System.Windows.Forms.AnchorStyles)5;
            designerControl14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            designerControl14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            designerControl14.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            designerControl14.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            designerControl14.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            designerControl14.AutoSize = true;
            designerControl14.Text = "Assign Instructor";
            designerControl14.TabIndex = 10;
            designerControl14.TabStop = false;
            designerControl14.Enabled = true;
            designerControl14.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            designerControl14.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            designerControl14.TextAlign = (System.Drawing.ContentAlignment)1;
            designerControl14.AutoEllipsis = false;
            designerControl14.MinimumSize = new System.Drawing.Size(0, 0);
            cboInstructor.Name = "cboInstructor";
            cboInstructor.Location = new System.Drawing.Point(310, 108);
            cboInstructor.Size = new System.Drawing.Size(260, 23);
            cboInstructor.Dock = (System.Windows.Forms.DockStyle)0;
            cboInstructor.Anchor = (System.Windows.Forms.AnchorStyles)5;
            cboInstructor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            cboInstructor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            cboInstructor.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            cboInstructor.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            cboInstructor.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            cboInstructor.AutoSize = false;
            cboInstructor.Text = "";
            cboInstructor.TabIndex = 11;
            cboInstructor.TabStop = true;
            cboInstructor.Enabled = true;
            cboInstructor.MaxLength = 0;
            cboInstructor.DropDownStyle = (System.Windows.Forms.ComboBoxStyle)2;
            cboInstructor.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            cboInstructor.IntegralHeight = true;
            cboInstructor.MinimumSize = new System.Drawing.Size(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Location = new System.Drawing.Point(590, 106);
            btnSave.Size = new System.Drawing.Size(130, 36);
            btnSave.Dock = (System.Windows.Forms.DockStyle)0;
            btnSave.Anchor = (System.Windows.Forms.AnchorStyles)5;
            btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            btnSave.BackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            btnSave.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            btnSave.AutoSize = false;
            btnSave.Text = "SAVE COURSE";
            btnSave.TabIndex = 12;
            btnSave.TabStop = true;
            btnSave.Enabled = true;
            btnSave.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            btnSave.TextAlign = (System.Drawing.ContentAlignment)32;
            btnSave.AutoEllipsis = false;
            btnSave.DialogResult = (System.Windows.Forms.DialogResult)0;
            btnSave.MinimumSize = new System.Drawing.Size(0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Location = new System.Drawing.Point(730, 106);
            btnCancel.Size = new System.Drawing.Size(130, 36);
            btnCancel.Dock = (System.Windows.Forms.DockStyle)0;
            btnCancel.Anchor = (System.Windows.Forms.AnchorStyles)5;
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 60, 60, 80);
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            btnCancel.AutoSize = false;
            btnCancel.Text = "CANCEL";
            btnCancel.TabIndex = 13;
            btnCancel.TabStop = true;
            btnCancel.Enabled = true;
            btnCancel.FlatStyle = (System.Windows.Forms.FlatStyle)0;
            btnCancel.TextAlign = (System.Drawing.ContentAlignment)32;
            btnCancel.AutoEllipsis = false;
            btnCancel.DialogResult = (System.Windows.Forms.DialogResult)0;
            btnCancel.MinimumSize = new System.Drawing.Size(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Location = new System.Drawing.Point(12, 8);
            lblFormTitle.Size = new System.Drawing.Size(104, 23);
            lblFormTitle.Dock = (System.Windows.Forms.DockStyle)0;
            lblFormTitle.Anchor = (System.Windows.Forms.AnchorStyles)5;
            lblFormTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblFormTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            lblFormTitle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)1);
            lblFormTitle.AutoSize = true;
            lblFormTitle.Text = "➕  New Course";
            lblFormTitle.TabIndex = 14;
            lblFormTitle.TabStop = false;
            lblFormTitle.Enabled = true;
            lblFormTitle.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            lblFormTitle.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            lblFormTitle.TextAlign = (System.Drawing.ContentAlignment)1;
            lblFormTitle.AutoEllipsis = false;
            lblFormTitle.MinimumSize = new System.Drawing.Size(0, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Location = new System.Drawing.Point(12, 162);
            lblMsg.Size = new System.Drawing.Size(800, 22);
            lblMsg.Dock = (System.Windows.Forms.DockStyle)0;
            lblMsg.Anchor = (System.Windows.Forms.AnchorStyles)5;
            lblMsg.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblMsg.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            lblMsg.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            lblMsg.ForeColor = System.Drawing.Color.FromArgb(255, 50, 205, 50);
            lblMsg.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            lblMsg.AutoSize = false;
            lblMsg.Text = "";
            lblMsg.TabIndex = 15;
            lblMsg.TabStop = false;
            lblMsg.Enabled = true;
            lblMsg.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            lblMsg.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            lblMsg.TextAlign = (System.Drawing.ContentAlignment)1;
            lblMsg.AutoEllipsis = false;
            lblMsg.MinimumSize = new System.Drawing.Size(0, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Location = new System.Drawing.Point(22, 292);
            lblTotal.Size = new System.Drawing.Size(99, 23);
            lblTotal.Dock = (System.Windows.Forms.DockStyle)0;
            lblTotal.Anchor = (System.Windows.Forms.AnchorStyles)5;
            lblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            lblTotal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            lblTotal.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 150, 150, 170);
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, (System.Drawing.FontStyle)0);
            lblTotal.AutoSize = true;
            lblTotal.Text = "Total courses: 0";
            lblTotal.TabIndex = 3;
            lblTotal.TabStop = false;
            lblTotal.Enabled = true;
            lblTotal.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            lblTotal.FlatStyle = (System.Windows.Forms.FlatStyle)2;
            lblTotal.TextAlign = (System.Drawing.ContentAlignment)1;
            lblTotal.AutoEllipsis = false;
            lblTotal.MinimumSize = new System.Drawing.Size(0, 0);
            grid.Name = "grid";
            grid.Location = new System.Drawing.Point(20, 316);
            grid.Size = new System.Drawing.Size(1100, 400);
            grid.Dock = (System.Windows.Forms.DockStyle)0;
            grid.Anchor = (System.Windows.Forms.AnchorStyles)5;
            grid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            grid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            grid.BackColor = System.Drawing.Color.FromArgb(255, 13, 17, 38);
            grid.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            grid.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            grid.AutoSize = false;
            grid.Text = "";
            grid.TabIndex = 4;
            grid.TabStop = true;
            grid.Enabled = true;
            grid.BorderStyle = (System.Windows.Forms.BorderStyle)0;
            grid.ReadOnly = true;
            grid.ScrollBars = (System.Windows.Forms.ScrollBars)3;
            grid.ColumnCount = 6;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = true;
            grid.MultiSelect = true;
            grid.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            grid.AutoSizeColumnsMode = (System.Windows.Forms.DataGridViewAutoSizeColumnsMode)16;
            grid.BackgroundColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            grid.GridColor = System.Drawing.Color.FromArgb(255, 35, 45, 70);
            grid.EnableHeadersVisualStyles = true;
            grid.RowHeadersVisible = false;
            grid.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
            grid.ColumnHeadersBorderStyle = (System.Windows.Forms.DataGridViewHeaderBorderStyle)2;
            grid.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)0;
            grid.ColumnHeadersHeight = 23;
            grid.MinimumSize = new System.Drawing.Size(0, 0);
            gridColumn0.Name = "Code";
            gridColumn0.HeaderText = "Code";
            gridColumn0.DataPropertyName = "";
            gridColumn0.Width = 120;
            gridColumn0.Visible = true;
            gridColumn0.ReadOnly = true;
            gridColumn0.FillWeight = 12F;
            gridColumn0.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            gridColumn1.Name = "Name";
            gridColumn1.HeaderText = "Course Name";
            gridColumn1.DataPropertyName = "";
            gridColumn1.Width = 250;
            gridColumn1.Visible = true;
            gridColumn1.ReadOnly = true;
            gridColumn1.FillWeight = 25F;
            gridColumn1.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            gridColumn2.Name = "Section";
            gridColumn2.HeaderText = "Section";
            gridColumn2.DataPropertyName = "";
            gridColumn2.Width = 120;
            gridColumn2.Visible = true;
            gridColumn2.ReadOnly = true;
            gridColumn2.FillWeight = 12F;
            gridColumn2.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            gridColumn3.Name = "Program";
            gridColumn3.HeaderText = "Program";
            gridColumn3.DataPropertyName = "";
            gridColumn3.Width = 249;
            gridColumn3.Visible = true;
            gridColumn3.ReadOnly = true;
            gridColumn3.FillWeight = 25F;
            gridColumn3.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            gridColumn4.Name = "Instr";
            gridColumn4.HeaderText = "Instructor";
            gridColumn4.DataPropertyName = "";
            gridColumn4.Width = 180;
            gridColumn4.Visible = true;
            gridColumn4.ReadOnly = true;
            gridColumn4.FillWeight = 18F;
            gridColumn4.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            gridColumn5.Name = "Enroll";
            gridColumn5.HeaderText = "Enrollment Code";
            gridColumn5.DataPropertyName = "";
            gridColumn5.Width = 180;
            gridColumn5.Visible = true;
            gridColumn5.ReadOnly = true;
            gridColumn5.FillWeight = 18F;
            gridColumn5.AutoSizeMode = (DataGridViewAutoSizeColumnMode)0;
            grid.Columns.AddRange(new DataGridViewColumn[] { gridColumn0, gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5 });
            grid.RowTemplate.Height = 36;
            gridColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 10, 15, 35);
            gridColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            gridColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)1);
            gridColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            gridColumnHeadersDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            gridColumnHeadersDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            grid.ColumnHeadersDefaultCellStyle = gridColumnHeadersDefaultCellStyle;
            gridAlternatingRowsDefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            gridAlternatingRowsDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)0;
            gridAlternatingRowsDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)0;
            grid.AlternatingRowsDefaultCellStyle = gridAlternatingRowsDefaultCellStyle;
            gridDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 22, 33, 62);
            gridDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            gridDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 233, 69, 96);
            gridDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            gridDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, (System.Drawing.FontStyle)0);
            gridDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            gridDefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
            gridDefaultCellStyle.WrapMode = (System.Windows.Forms.DataGridViewTriState)2;
            grid.DefaultCellStyle = gridDefaultCellStyle;
            this.Controls.Add(designerControl1);
            this.Controls.Add(designerControl2);
            this.Controls.Add(designerControl3);
            designerControl3.Controls.Add(designerControl4);
            designerControl3.Controls.Add(txtCode);
            designerControl3.Controls.Add(designerControl6);
            designerControl3.Controls.Add(txtName);
            designerControl3.Controls.Add(designerControl8);
            designerControl3.Controls.Add(txtSection);
            designerControl3.Controls.Add(designerControl10);
            designerControl3.Controls.Add(txtEnrollCode);
            designerControl3.Controls.Add(designerControl12);
            designerControl3.Controls.Add(cboProgram);
            designerControl3.Controls.Add(designerControl14);
            designerControl3.Controls.Add(cboInstructor);
            designerControl3.Controls.Add(btnSave);
            designerControl3.Controls.Add(btnCancel);
            designerControl3.Controls.Add(lblFormTitle);
            designerControl3.Controls.Add(lblMsg);
            this.Controls.Add(lblTotal);
            this.Controls.Add(grid);
            this.Load += this_Load;
            btnSave.Click += BtnSave_Click;
            grid.SelectionChanged += Grid_SelectionChanged;
            btnCancel.Click += btnCancel_Click;
            designerControl3.ResumeLayout(false);
            designerControl3.PerformLayout();
            ResumeLayout(false);
    }
    #endregion

    private void this_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || DesignMode) return;
        cboProgram.SelectedIndex = 0;
        LoadInstructors();
        LoadCourses();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        ResetForm();
    }

        // ── Colors matching your app theme ────────────────────────────
        private static readonly Color BgColor = Color.FromArgb(13, 17, 38);
        private static readonly Color CardColor = Color.FromArgb(22, 33, 62);
        private static readonly Color AccentColor = Color.FromArgb(233, 69, 96);
        private static readonly Color TextColor = Color.White;
        private static readonly Color GrayText = Color.FromArgb(150, 150, 170);

        private static readonly string[] Programs =
        {
            "All Programs",
            "BS Computer Engineering",
            "BS Civil Engineering",
            "BS Electrical Engineering",
            "BS Mechanical Engineering",
            "BS Electronics Engineering",
            "BS Chemical Engineering",
            "BS Information Technology",
            "BS Computer Science",
            "BS Architecture",
            "BS Nursing",
            "BS Education",
            "BS Business Administration"
        };

        // ── Controls ─────────────────────────────────────────────────

        // ── State ─────────────────────────────────────────────────────
        private List<CourseRow> _courses = new List<CourseRow>();
        private List<InstructorItem> _instructors = new List<InstructorItem>();
        private int _editingId = -1;

        // Simple data holders
        private class CourseRow
        {
            public int Id { get; set; }
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
            public string Section { get; set; }
            public string Program { get; set; }
            public int InstructorId { get; set; }
            public string InstructorName { get; set; }
            public string EnrollmentCode { get; set; }
        }

        private class InstructorItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        // ─────────────────────────────────────────────────────────────
        public Courses()
        {
            this.InitializeComponent();
        }

        // Database loading runs after the control is initialized.
        private void LoadInstructors()
        {
            cboInstructor.Items.Clear();
            _instructors.Clear();
            string sql = "SELECT InstructorId, FullName FROM Instructors ORDER BY FullName";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var item = new InstructorItem
                        {
                            Id = r.GetInt32(0),
                            Name = r.GetString(1)
                        };
                        _instructors.Add(item);
                        cboInstructor.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg("Could not load instructors: " + ex.Message, false);
            }
        }

        // ── Load courses into grid ────────────────────────────────────
        private void LoadCourses()
        {
            grid.Rows.Clear();
            _courses.Clear();

            string sql = @"
                SELECT c.CourseId, c.CourseCode, c.CourseName,
                       c.Section, c.Program, c.InstructorId,
                       COALESCE(i.FullName,'Unassigned') as InstrName,
                       c.EnrollmentCode
                FROM Courses c
                LEFT JOIN Instructors i ON c.InstructorId = i.InstructorId
                ORDER BY c.CourseCode";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var row = new CourseRow
                        {
                            Id = r.GetInt32(0),
                            CourseCode = r.GetString(1),
                            CourseName = r.GetString(2),
                            Section = r.GetString(3),
                            Program = r.GetString(4),
                            InstructorId = r.IsDBNull(5) ? 0 : r.GetInt32(5),
                            InstructorName = r.GetString(6),
                            EnrollmentCode = r.GetString(7)
                        };
                        _courses.Add(row);
                        grid.Rows.Add(row.CourseCode, row.CourseName, row.Section,
                                      row.Program, row.InstructorName, row.EnrollmentCode);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMsg("Error loading courses: " + ex.Message, false);
            }

            lblTotal.Text = $"Total courses: {_courses.Count}";
        }

        // ── Row click → fill form ─────────────────────────────────────
        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            int idx = grid.SelectedRows[0].Index;
            if (idx < 0 || idx >= _courses.Count) return;

            var c = _courses[idx];
            _editingId = c.Id;

            txtCode.Text = c.CourseCode;
            txtName.Text = c.CourseName;
            txtSection.Text = c.Section;
            txtEnrollCode.Text = c.EnrollmentCode;
            txtEnrollCode.Enabled = false; // Cannot change enrollment code

            // Set program combo
            for (int i = 0; i < cboProgram.Items.Count; i++)
                if (cboProgram.Items[i].ToString() == c.Program)
                { cboProgram.SelectedIndex = i; break; }

            // Set instructor combo
            cboInstructor.SelectedIndex = -1;
            foreach (InstructorItem item in cboInstructor.Items)
                if (item.Id == c.InstructorId)
                { cboInstructor.SelectedItem = item; break; }

            lblFormTitle.Text = $"✏️  Editing: {c.CourseCode} — {c.CourseName}";
            btnSave.Text = "UPDATE COURSE";
            btnSave.BackColor = Color.FromArgb(0, 140, 200);
            ShowMsg("Edit the fields then click UPDATE COURSE.", true);
        }

        // ── Save (Add or Update) ──────────────────────────────────────
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validate
            if (txtCode.Text.Trim().Length == 0)
            { ShowMsg("Course code is required.", false); return; }
            if (txtName.Text.Trim().Length == 0)
            { ShowMsg("Course name is required.", false); return; }
            if (txtSection.Text.Trim().Length == 0)
            { ShowMsg("Section is required.", false); return; }
            if (txtEnrollCode.Text.Trim().Length == 0)
            { ShowMsg("Enrollment code is required.", false); return; }
            if (cboInstructor.SelectedItem == null)
            { ShowMsg("Please select an instructor.", false); return; }

            var instr = (InstructorItem)cboInstructor.SelectedItem;
            string program = cboProgram.SelectedItem?.ToString() ?? "All Programs";

            if (_editingId < 0)
            {
                // ADD new course
                bool ok = AddCourse(txtCode.Text.Trim(), txtName.Text.Trim(),
                                     txtSection.Text.Trim(), program,
                                     instr.Id, txtEnrollCode.Text.Trim());
                ShowMsg(ok ? "✅ Course added successfully!"
                           : "❌ Enrollment code already exists.", ok);
                if (ok) { ResetForm(); LoadCourses(); }
            }
            else
            {
                // UPDATE existing course
                bool ok = UpdateCourse(_editingId, txtCode.Text.Trim(),
                                        txtName.Text.Trim(), txtSection.Text.Trim(),
                                        program, instr.Id);
                ShowMsg(ok ? "✅ Course updated successfully!"
                           : "❌ Error updating course.", ok);
                if (ok) { ResetForm(); LoadCourses(); }
            }
        }

        // ── Database operations ───────────────────────────────────────
        private bool AddCourse(string code, string name, string section,
                                string program, int instructorId, string enrollCode)
        {
            string sql = @"
                INSERT INTO Courses
                    (CourseCode, CourseName, Section, Program, InstructorId, EnrollmentCode)
                VALUES
                    (@code, @name, @section, @program, @iid, @enroll)";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@program", program);
                    cmd.Parameters.AddWithValue("@iid", instructorId);
                    cmd.Parameters.AddWithValue("@enroll", enrollCode);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        private bool UpdateCourse(int id, string code, string name,
                                   string section, string program, int instructorId)
        {
            string sql = @"
                UPDATE Courses
                SET CourseCode=@code, CourseName=@name,
                    Section=@section, Program=@program, InstructorId=@iid
                WHERE CourseId=@id";
            try
            {
                using (var conn = AuthService.GetConnection())
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@program", program);
                    cmd.Parameters.AddWithValue("@iid", instructorId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        // ── Reset form to Add mode ────────────────────────────────────
        private void ResetForm()
        {
            _editingId = -1;
            txtCode.Text = txtName.Text = txtSection.Text = txtEnrollCode.Text = "";
            txtEnrollCode.Enabled = true;
            cboProgram.SelectedIndex = 0;
            cboInstructor.SelectedIndex = -1;
            lblFormTitle.Text = "➕  New Course";
            btnSave.Text = "SAVE COURSE";
            btnSave.BackColor = AccentColor;
            lblMsg.Text = "";
            grid.ClearSelection();
        }

        private void ShowMsg(string text, bool success)
        {
            lblMsg.Text = text;
            lblMsg.ForeColor = success ? Color.LimeGreen : Color.FromArgb(233, 69, 96);
        }
    }
}