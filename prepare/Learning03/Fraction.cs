using System;

public class Fraction{

    private int _top;
    private int _bottom;
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top){
        _top = top;
    }

    public void SetBottom( int bottom){
        _bottom = bottom;
    }

    public int GetTop(){
        return _top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue(){
        double _decimal = (double)_top / (double)_bottom;
        return _decimal;   
    }
}