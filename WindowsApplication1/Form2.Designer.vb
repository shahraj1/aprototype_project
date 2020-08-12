<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(306, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientName, Me.Doctor, Me.AppointmentTime, Me.Active})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(726, 220)
        Me.DataGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.969231!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sort By:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Appointment Time"})
        Me.ComboBox1.Location = New System.Drawing.Point(306, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'PatientName
        '
        Me.PatientName.FillWeight = 200.0!
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'Doctor
        '
        Me.Doctor.HeaderText = "Doctor"
        Me.Doctor.Name = "Doctor"
        Me.Doctor.ReadOnly = True
        '
        'AppointmentTime
        '
        Me.AppointmentTime.HeaderText = "Appointment Time"
        Me.AppointmentTime.Name = "AppointmentTime"
        Me.AppointmentTime.ReadOnly = True
        Me.AppointmentTime.Width = 200
        '
        'Active
        '
        Me.Active.HeaderText = "Active"
        Me.Active.Name = "Active"
        Me.Active.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 382)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Doctor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppointmentTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Active As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
