using System;
using Xunit;

namespace miniKatas;

public class Tests
{
    [Fact]
    public void Multiply_function_should_multiply_inputs()
    {
        var solution = new MathFunctions();
        var expected = 25;
        var test = solution.Multiply(5, 5);
        Assert.Equal(expected, test);
    }

    [Fact]
    public void Divide_function_should_divide_inputs()
    {
        var solution = new MathFunctions();
        var expected = 2;
        var test = solution.Divide(10, 5);
        Assert.Equal(expected, test);
    }

    [Fact]
    public void Divide_should_throw_when_dividing_with_zero()
    {
        var solution = new MathFunctions();
        // asserts that en exception is thrown when we call the emailMaker with special characters.
        Assert.Throws<ArgumentException>(() => { solution.Divide(5, 0); });
    }

    [Fact]
    public void No_spaces_function_should_remove_spaces_from_string_input()
    {
        var expected = "hitheremynameisossian";
        var solution = new StringFunctions();
        var test = solution.NoSpaces("hi there my name is ossian");
        Assert.Equal(test, expected);
    }

    [Fact]
    public void No_spaces_function_should_remove_special_characters_from_string_input()
    {
        var expected = "hitheremynameisossian";
        var solution = new StringFunctions();
        var test = solution.NoSpaces("hi!there my *name* is : ossian");
        Assert.Equal(test, expected);
    }

    [Fact]
    public void No_spaces_function_should_lowercase_all_characters()
    {
        var expected = "hitheremynameisossian";
        var solution = new StringFunctions();
        var test = solution.NoSpaces("Hi!tHere my *NAME* is : ossian");
        Assert.Equal(test, expected);
    }

    [Fact]
    public void Should_add_gmail_dot_com_after_string_input()
    {
        var expected = "elon@gmail.com";
        var solution = new StringFunctions();
        var test = solution.EmailMaker("elon");
        Assert.Equal(test, expected);
    }

    [Fact]
    public void Should_concatenate_firstname_and_lastname_with_a_dot_in_between()
    {
        var expected = "elon.julius.musk@gmail.com";
        var solution = new StringFunctions();
        var test = solution.EmailMaker("elon julius musk");
        Assert.Equal(test, expected);
    }

    [Fact]
    public void Should_throw_an_error_if_input_contains_special_characters()
    {
        var solution = new StringFunctions();
        // asserts that en exception is thrown when we call the emailMaker with special characters.
        Assert.Throws<Exception>(() => { solution.EmailMaker("////8HD8AHD"); });
    }

    [Fact]
    public void SmallestNumber_function_should_return_smallest_number_from_an_array_input()
    {
        var expected = 12;
        var solution = new ListFunctions();
        var test = solution.Smallest(new[] {21, 521, 12, 90});
        Assert.Equal(test, expected);
    }

    [Fact]
    public void Sort_function_should_sort_the_numbers_in_an_array_from_smallest_to_largest()
    {
        var expected = new[] {0, 1, 2, 3, 4, 5};
        var solution = new ListFunctions();
        var test = solution.Sort(new[] {2, 1, 3, 5, 4, 0});
        Assert.Equal(test, expected);
    }
}