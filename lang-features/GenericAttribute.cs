namespace lang_features;

public class GenericType<T>
{
    [GenericAttribute<string>()]
    string Method() => "test";
}

public class GenericAttribute<T> : Attribute { }
