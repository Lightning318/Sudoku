namespace Sudoku.Pages;

using Sudoku.Model;

partial class SudokuGame {
    //State
    public SudokuCell[] Cells;
    public EditMode EditMode { get; set;}
    private int selectedNumber = 1;

    private string selectedMode = "edit";

    public SudokuGame(string? initialValues = null) {
        initialValues ??= new string('0',  81);
        Cells = CreateCellsFromString(initialValues);
    }

    private static SudokuCell[] CreateCellsFromString(string input) {
        return [.. input.Select(c => new SudokuCell(int.Parse(c.ToString())))];
    }

    private void UpdateCell(int cellIndex) {
        Console.WriteLine($"clicked cell {cellIndex}");
        Cells[cellIndex].Value = selectedNumber;
        StateHasChanged();
    }
}

public enum EditMode {
    Edit,
    Candidate,
    Delete,
}
