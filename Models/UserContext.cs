namespace MyBlazorApp.Models;

/// <summary>
/// カスケーディングパラメータで渡すユーザーコンテキスト
/// </summary>
public class UserContext
{
    public string UserName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string ThemeColor { get; set; } = "#0078d4";

    public bool IsAdmin => Role == "Admin";
}
