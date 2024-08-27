Friend Class MyRender
    Inherits ToolStripProfessionalRenderer

    Public Sub New()
        MyBase.New(New MyColorTable())
    End Sub
End Class

Public Class MyColorTable
    Inherits ProfessionalColorTable
    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return Color.FromArgb(255, 153, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color.FromArgb(255, 204, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark As Color
        Get
            Return Color.FromArgb(255, 0, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return Color.FromArgb(255, 153, 255)
        End Get
    End Property
End Class
