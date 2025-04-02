using System.Collections.Immutable;

namespace lang_features;

file class Article(int id, string title, int[] scores)
{
    public Article() : this(0, string.Empty, []) {}
}