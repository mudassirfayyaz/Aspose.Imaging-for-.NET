﻿Imports Aspose.Imaging.FileFormats.Dicom
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DICOM
    Class GrayscalingOnDICOM
        Public Shared Sub Run()
            ' ExStart:GrayscalingOnDICOM
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DICOM()

            ' Load an existing image.
            Using image As New DicomImage(dataDir & Convert.ToString("image.dcm"))

                ' Transform image to its grayscale representation and Save the resultant image.
                image.Grayscale()
                image.Save(dataDir + Convert.ToString("GrayscalingOnDICOM_out.bmp"), New BmpOptions())
            End Using
            ' ExEnd:GrayscalingOnDICOM
        End Sub
    End Class
End Namespace
