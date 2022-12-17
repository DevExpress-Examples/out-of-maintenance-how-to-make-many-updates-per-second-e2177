Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports System.ComponentModel
Imports System
Imports System.Windows.Threading
Imports System.Windows.Forms

Namespace DXGrid_ConditionalFormatting

    Public Partial Class Window1
        Inherits Window

        Const ItemsSourceRowCount As Integer = 10000

        Const RefreshDataIntervalInMilliseconds As Integer = 1

        Const UpdatedCellsCount As Integer = 10000

        Private list As List(Of SampleData) = New List(Of SampleData)()

        Private rnd As Random = New Random()

        Private timer As Timer = New Timer()

        Private lastSecond As Long = Environment.TickCount

        Private refreshCount As Integer

        Public Sub New()
            Me.InitializeComponent()
            For i As Integer = 0 To ItemsSourceRowCount - 1
                list.Add(New SampleData())
            Next

            Me.grid.ItemsSource = list
            AddHandler Loaded, New RoutedEventHandler(AddressOf Window1_Loaded)
        End Sub

        Private Sub Window1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            timer.Interval = RefreshDataIntervalInMilliseconds
            AddHandler timer.Tick, New EventHandler(AddressOf timer_Tick)
            timer.Start()
        End Sub

        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(SampleData))
            For i As Integer = 0 To UpdatedCellsCount - 1
                list(rnd.Next(list.Count)).SetValue(rnd.Next(properties.Count), rnd.Next(100000))
            Next

            If Not refreshQueued Then
                refreshQueued = True
                Me.grid.Dispatcher.BeginInvoke(New Action(AddressOf RefreshData), DispatcherPriority.ApplicationIdle)
            End If
        End Sub

        Private refreshQueued As Boolean

        Private Sub RefreshData()
            refreshQueued = False
            Me.grid.RefreshData()
            Dim currentTickCount As Integer = Environment.TickCount
            If currentTickCount - lastSecond > TimeSpan.FromSeconds(1).TotalMilliseconds Then
                Me.refreshCountTextBlock.Text = " " & refreshCount
                refreshCount = 0
                lastSecond = currentTickCount
            End If

            refreshCount += 1
        End Sub
    End Class

    Public Class SampleData

        Private values As Integer() = New Integer(99) {}

'#Region "properties"
        Public ReadOnly Property Property0 As Integer
            Get
                Return values(0)
            End Get
        End Property

        Public ReadOnly Property Property1 As Integer
            Get
                Return values(1)
            End Get
        End Property

        Public ReadOnly Property Property2 As Integer
            Get
                Return values(2)
            End Get
        End Property

        Public ReadOnly Property Property3 As Integer
            Get
                Return values(3)
            End Get
        End Property

        Public ReadOnly Property Property4 As Integer
            Get
                Return values(4)
            End Get
        End Property

        Public ReadOnly Property Property5 As Integer
            Get
                Return values(5)
            End Get
        End Property

        Public ReadOnly Property Property6 As Integer
            Get
                Return values(6)
            End Get
        End Property

        Public ReadOnly Property Property7 As Integer
            Get
                Return values(7)
            End Get
        End Property

        Public ReadOnly Property Property8 As Integer
            Get
                Return values(8)
            End Get
        End Property

        Public ReadOnly Property Property9 As Integer
            Get
                Return values(9)
            End Get
        End Property

        Public ReadOnly Property Property10 As Integer
            Get
                Return values(10)
            End Get
        End Property

        Public ReadOnly Property Property11 As Integer
            Get
                Return values(11)
            End Get
        End Property

        Public ReadOnly Property Property12 As Integer
            Get
                Return values(12)
            End Get
        End Property

        Public ReadOnly Property Property13 As Integer
            Get
                Return values(13)
            End Get
        End Property

        Public ReadOnly Property Property14 As Integer
            Get
                Return values(14)
            End Get
        End Property

        Public ReadOnly Property Property15 As Integer
            Get
                Return values(15)
            End Get
        End Property

        Public ReadOnly Property Property16 As Integer
            Get
                Return values(16)
            End Get
        End Property

        Public ReadOnly Property Property17 As Integer
            Get
                Return values(17)
            End Get
        End Property

        Public ReadOnly Property Property18 As Integer
            Get
                Return values(18)
            End Get
        End Property

        Public ReadOnly Property Property19 As Integer
            Get
                Return values(19)
            End Get
        End Property

        Public ReadOnly Property Property20 As Integer
            Get
                Return values(20)
            End Get
        End Property

        Public ReadOnly Property Property21 As Integer
            Get
                Return values(21)
            End Get
        End Property

        Public ReadOnly Property Property22 As Integer
            Get
                Return values(22)
            End Get
        End Property

        Public ReadOnly Property Property23 As Integer
            Get
                Return values(23)
            End Get
        End Property

        Public ReadOnly Property Property24 As Integer
            Get
                Return values(24)
            End Get
        End Property

        Public ReadOnly Property Property25 As Integer
            Get
                Return values(25)
            End Get
        End Property

        Public ReadOnly Property Property26 As Integer
            Get
                Return values(26)
            End Get
        End Property

        Public ReadOnly Property Property27 As Integer
            Get
                Return values(27)
            End Get
        End Property

        Public ReadOnly Property Property28 As Integer
            Get
                Return values(28)
            End Get
        End Property

        Public ReadOnly Property Property29 As Integer
            Get
                Return values(29)
            End Get
        End Property

        Public ReadOnly Property Property30 As Integer
            Get
                Return values(30)
            End Get
        End Property

        Public ReadOnly Property Property31 As Integer
            Get
                Return values(31)
            End Get
        End Property

        Public ReadOnly Property Property32 As Integer
            Get
                Return values(32)
            End Get
        End Property

        Public ReadOnly Property Property33 As Integer
            Get
                Return values(33)
            End Get
        End Property

        Public ReadOnly Property Property34 As Integer
            Get
                Return values(34)
            End Get
        End Property

        Public ReadOnly Property Property35 As Integer
            Get
                Return values(35)
            End Get
        End Property

        Public ReadOnly Property Property36 As Integer
            Get
                Return values(36)
            End Get
        End Property

        Public ReadOnly Property Property37 As Integer
            Get
                Return values(37)
            End Get
        End Property

        Public ReadOnly Property Property38 As Integer
            Get
                Return values(38)
            End Get
        End Property

        Public ReadOnly Property Property39 As Integer
            Get
                Return values(39)
            End Get
        End Property

        Public ReadOnly Property Property40 As Integer
            Get
                Return values(40)
            End Get
        End Property

        Public ReadOnly Property Property41 As Integer
            Get
                Return values(41)
            End Get
        End Property

        Public ReadOnly Property Property42 As Integer
            Get
                Return values(42)
            End Get
        End Property

        Public ReadOnly Property Property43 As Integer
            Get
                Return values(43)
            End Get
        End Property

        Public ReadOnly Property Property44 As Integer
            Get
                Return values(44)
            End Get
        End Property

        Public ReadOnly Property Property45 As Integer
            Get
                Return values(45)
            End Get
        End Property

        Public ReadOnly Property Property46 As Integer
            Get
                Return values(46)
            End Get
        End Property

        Public ReadOnly Property Property47 As Integer
            Get
                Return values(47)
            End Get
        End Property

        Public ReadOnly Property Property48 As Integer
            Get
                Return values(48)
            End Get
        End Property

        Public ReadOnly Property Property49 As Integer
            Get
                Return values(49)
            End Get
        End Property

        Public ReadOnly Property Property50 As Integer
            Get
                Return values(50)
            End Get
        End Property

        Public ReadOnly Property Property51 As Integer
            Get
                Return values(51)
            End Get
        End Property

        Public ReadOnly Property Property52 As Integer
            Get
                Return values(52)
            End Get
        End Property

        Public ReadOnly Property Property53 As Integer
            Get
                Return values(53)
            End Get
        End Property

        Public ReadOnly Property Property54 As Integer
            Get
                Return values(54)
            End Get
        End Property

        Public ReadOnly Property Property55 As Integer
            Get
                Return values(55)
            End Get
        End Property

        Public ReadOnly Property Property56 As Integer
            Get
                Return values(56)
            End Get
        End Property

        Public ReadOnly Property Property57 As Integer
            Get
                Return values(57)
            End Get
        End Property

        Public ReadOnly Property Property58 As Integer
            Get
                Return values(58)
            End Get
        End Property

        Public ReadOnly Property Property59 As Integer
            Get
                Return values(59)
            End Get
        End Property

        Public ReadOnly Property Property60 As Integer
            Get
                Return values(60)
            End Get
        End Property

        Public ReadOnly Property Property61 As Integer
            Get
                Return values(61)
            End Get
        End Property

        Public ReadOnly Property Property62 As Integer
            Get
                Return values(62)
            End Get
        End Property

        Public ReadOnly Property Property63 As Integer
            Get
                Return values(63)
            End Get
        End Property

        Public ReadOnly Property Property64 As Integer
            Get
                Return values(64)
            End Get
        End Property

        Public ReadOnly Property Property65 As Integer
            Get
                Return values(65)
            End Get
        End Property

        Public ReadOnly Property Property66 As Integer
            Get
                Return values(66)
            End Get
        End Property

        Public ReadOnly Property Property67 As Integer
            Get
                Return values(67)
            End Get
        End Property

        Public ReadOnly Property Property68 As Integer
            Get
                Return values(68)
            End Get
        End Property

        Public ReadOnly Property Property69 As Integer
            Get
                Return values(69)
            End Get
        End Property

        Public ReadOnly Property Property70 As Integer
            Get
                Return values(70)
            End Get
        End Property

        Public ReadOnly Property Property71 As Integer
            Get
                Return values(71)
            End Get
        End Property

        Public ReadOnly Property Property72 As Integer
            Get
                Return values(72)
            End Get
        End Property

        Public ReadOnly Property Property73 As Integer
            Get
                Return values(73)
            End Get
        End Property

        Public ReadOnly Property Property74 As Integer
            Get
                Return values(74)
            End Get
        End Property

        Public ReadOnly Property Property75 As Integer
            Get
                Return values(75)
            End Get
        End Property

        Public ReadOnly Property Property76 As Integer
            Get
                Return values(76)
            End Get
        End Property

        Public ReadOnly Property Property77 As Integer
            Get
                Return values(77)
            End Get
        End Property

        Public ReadOnly Property Property78 As Integer
            Get
                Return values(78)
            End Get
        End Property

        Public ReadOnly Property Property79 As Integer
            Get
                Return values(79)
            End Get
        End Property

        Public ReadOnly Property Property80 As Integer
            Get
                Return values(80)
            End Get
        End Property

        Public ReadOnly Property Property81 As Integer
            Get
                Return values(81)
            End Get
        End Property

        Public ReadOnly Property Property82 As Integer
            Get
                Return values(82)
            End Get
        End Property

        Public ReadOnly Property Property83 As Integer
            Get
                Return values(83)
            End Get
        End Property

        Public ReadOnly Property Property84 As Integer
            Get
                Return values(84)
            End Get
        End Property

        Public ReadOnly Property Property85 As Integer
            Get
                Return values(85)
            End Get
        End Property

        Public ReadOnly Property Property86 As Integer
            Get
                Return values(86)
            End Get
        End Property

        Public ReadOnly Property Property87 As Integer
            Get
                Return values(87)
            End Get
        End Property

        Public ReadOnly Property Property88 As Integer
            Get
                Return values(88)
            End Get
        End Property

        Public ReadOnly Property Property89 As Integer
            Get
                Return values(89)
            End Get
        End Property

        Public ReadOnly Property Property90 As Integer
            Get
                Return values(90)
            End Get
        End Property

        Public ReadOnly Property Property91 As Integer
            Get
                Return values(91)
            End Get
        End Property

        Public ReadOnly Property Property92 As Integer
            Get
                Return values(92)
            End Get
        End Property

        Public ReadOnly Property Property93 As Integer
            Get
                Return values(93)
            End Get
        End Property

        Public ReadOnly Property Property94 As Integer
            Get
                Return values(94)
            End Get
        End Property

        Public ReadOnly Property Property95 As Integer
            Get
                Return values(95)
            End Get
        End Property

        Public ReadOnly Property Property96 As Integer
            Get
                Return values(96)
            End Get
        End Property

        Public ReadOnly Property Property97 As Integer
            Get
                Return values(97)
            End Get
        End Property

        Public ReadOnly Property Property98 As Integer
            Get
                Return values(98)
            End Get
        End Property

        Public ReadOnly Property Property99 As Integer
            Get
                Return values(99)
            End Get
        End Property

'#End Region  ' properties
        Public Sub SetValue(ByVal index As Integer, ByVal value As Integer)
            values(index) = value
        End Sub
    End Class
End Namespace
