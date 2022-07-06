﻿Namespace Bsharp.CodeAnalysis.Binding

  Friend NotInheritable Class BoundNopStatement
    Inherits BoundStatement

    Public Overrides ReadOnly Property Kind As BoundNodeKind = BoundNodeKind.RemStatement

  End Class

End Namespace