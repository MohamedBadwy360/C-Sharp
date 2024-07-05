namespace FileScopenamespace;

// File scope namespace is a namespace without a curly braces body and any type in this file will be in this namespace.
// This is a new feature in C# 10.
// This is useful when we have a single file with multiple types and we want to put them in a namespace.
// It's allowed to have only one file scope namespace in a file.
// It's not allowed to have a file scope namespace with a namespace with a curly braces body in the same file.
// Nesting file scope namespaces is not allowed.

internal class FileScopenamespace
{
}
