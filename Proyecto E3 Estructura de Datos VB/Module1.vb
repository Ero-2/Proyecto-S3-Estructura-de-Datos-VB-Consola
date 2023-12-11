Module Module1

    Sub Main()
        ' Lista Enlazada
        Dim linkedList As New LinkedList(Of Integer)()
        linkedList.AddLast(1)
        linkedList.AddLast(2)
        linkedList.AddLast(3)

        Console.WriteLine("Linked List:")
        For Each item In linkedList
            Console.Write($"{item} ")
        Next
        Console.WriteLine()

        ' Pila
        Dim stack As New Stack(Of Integer)()
        stack.Push(1)
        stack.Push(2)
        stack.Push(3)

        Console.WriteLine(vbCrLf & "Stack:")
        While stack.Count > 0
            Console.Write($"{stack.Pop()} ")
        End While
        Console.WriteLine()

        ' Cola
        Dim queue As New Queue(Of Integer)()
        queue.Enqueue(1)
        queue.Enqueue(2)
        queue.Enqueue(3)

        Console.WriteLine(vbCrLf & "Queue:")
        While queue.Count > 0
            Console.Write($"{queue.Dequeue()} ")
        End While
        Console.WriteLine()

        ' Árbol Binario
        Dim root As New TreeNode(1)
        root.Left = New TreeNode(2)
        root.Right = New TreeNode(3)

        Console.WriteLine(vbCrLf & "Binary Tree (Inorder Traversal):")
        InorderTraversal(root)
        Console.WriteLine()

        ' Grafo No Dirigido
        Dim graph As New Graph()
        graph.AddVertex(1)
        graph.AddVertex(2)
        graph.AddVertex(3)

        graph.AddEdge(1, 2)
        graph.AddEdge(2, 3)

        Console.WriteLine(vbCrLf & "Graph Representation:")
        graph.PrintGraph()

        Console.ReadKey()

    End Sub

    Sub InorderTraversal(node As TreeNode)
        If node IsNot Nothing Then
            InorderTraversal(node.Left)
            Console.Write($"{node.Value} ")
            InorderTraversal(node.Right)
        End If
    End Sub
End Module


