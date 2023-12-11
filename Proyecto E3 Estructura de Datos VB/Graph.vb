Public Class Graph
    Private adjacencyList As Dictionary(Of Integer, List(Of Integer))

    Public Sub New()
        adjacencyList = New Dictionary(Of Integer, List(Of Integer))()
    End Sub

    Public Sub AddVertex(vertex As Integer)
        adjacencyList(vertex) = New List(Of Integer)()
    End Sub

    Public Sub AddEdge(source As Integer, destination As Integer)
        adjacencyList(source).Add(destination)
        adjacencyList(destination).Add(source)
    End Sub

    Public Sub PrintGraph()
        For Each vertex In adjacencyList.Keys
            Console.Write($"{vertex}: ")
            For Each neighbor In adjacencyList(vertex)
                Console.Write($"{neighbor} ")
            Next
            Console.WriteLine()
        Next
    End Sub

End Class
