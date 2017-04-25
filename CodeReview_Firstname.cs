
public class CodeReview {

    /// <summary>
/// This method returns integer parsed from the source.
/// If parsing fails it should return zero.
/// </summary>
/// <param name="o">Object with data to parse.</param>
/// <returns>Parsed value</returns>

    public int Parse(Object o) {
        try {
            return (int)o;
        } catch (Exception e) {
            return 0;
        }
    }

    /// <summary>
/// This method returns concatenated string from the array of the strings.
/// </summary>
/// <param name="lines">Array of strings with lines.</param>
/// <returns>Concatenated string.</returns>

    public String Concat(String[] lines) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < lines.length; i++) {
            result.append(lines[i]);
        }
        return result.toString();
    }
}