Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports System.IO
Public Class Form1

    Private location As String = "elly.json"
    Private Sub convertbtn_Click(sender As Object, e As EventArgs) Handles convertbtn.Click
        Dim readJson As String = File.ReadAllText(location)
        Dim finaloutput As getdata = JsonConvert.DeserializeObject(Of getdata)(readJson)
        Dim pdfFile As Document = New Document()
        PdfWriter.GetInstance(pdfFile, New FileStream("Santos,John Ellyson.pdf", FileMode.Create))
        pdfFile.Open()

        Dim Name As Paragraph = New Paragraph(finaloutput.Name)
        Name.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(Name)

        Dim Address As Paragraph = New Paragraph(finaloutput.Address)
        Address.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(Address)
        Dim ContactNumber As Paragraph = New Paragraph(finaloutput.ContactNumber)
        ContactNumber.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(ContactNumber)
        Dim Email As Paragraph = New Paragraph(finaloutput.Email & vbLf & vbLf)
        Email.Alignment = Element.ALIGN_CENTER
        pdfFile.Add(Email)



        Dim WorkExperience As Paragraph = New Paragraph("Work Experience: " & finaloutput.WorkExperience & vbLf)
        WorkExperience.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(WorkExperience)

        Dim Nationality As Paragraph = New Paragraph("Nationality: " & finaloutput.Nationality)
        Nationality.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(Nationality)
        Dim CivilStatus As Paragraph = New Paragraph("Civil Status: " & finaloutput.CivilStatus & vbLf)
        CivilStatus.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(CivilStatus)

        Dim Skills As Paragraph = New Paragraph("Civil Status: " & finaloutput.Skills & vbLf)
        Skills.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(Skills)

        Dim Hobby As Paragraph = New Paragraph("Hobby: " & finaloutput.Hobby & vbLf)
        Skills.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(Hobby)

        Dim objectiv As Paragraph = New Paragraph("OBJECTIVE:")
        objectiv.Font.Size = 18
        objectiv.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(objectiv)

        Dim Objective As Paragraph = New Paragraph(finaloutput.Objective & vbLf & vbLf)
        Objective.IndentationLeft = 40
        Objective.Alignment = Element.ALIGN_LEFT
        pdfFile.Add(Objective)

        Dim myesigpic As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(finaloutput.myesigpic)
        myesigpic.ScalePercent(15.0F)
        myesigpic.Alignment = iTextSharp.text.Image.UNDERLYING Or iTextSharp.text.Image.ALIGN_RIGHT
        myesigpic.IndentationRight = -20

        pdfFile.Add(myesigpic)

        Dim Name1 As Paragraph = New Paragraph(vbLf & vbLf & vbLf & vbLf & vbLf & finaloutput.Name)
        Name1.Alignment = Element.ALIGN_RIGHT
        pdfFile.Add(Name1)
        pdfFile.Close()
        MessageBox.Show("Your PDF has been created!")
    End Sub
    Public Class getdata
        Public Property Name As String
        Public Property Age As String
        Public Property Address As String
        Public Property ContactNumber As String
        Public Property Education As String
        Public Property WorkExperience As String
        Public Property Skills As String
        Public Property Nationality As String
        Public Property CivilStatus As String
        Public Property Objective As String
        Public Property Hobby As String
        Public Property Email As String
        Public Property myesigpic As String
    End Class
End Class

