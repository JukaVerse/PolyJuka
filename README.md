## Accessibility Types 
`external` -> Public<br>
`internal` -> Private <br>
`static` -> Static<br>
`pub` -> Public for used namespace
<br>

## Operations
Name | Token
-----|------
Equals | `=`
Compare | `==`
Not Equal To | `!=`
Greater then or equal to | `>=`
Less then or equal to | `<=`
Greater Then | `<`
Less then | `>`
Not | `!`
Add | `+`
Subtract | `-`
Exponent | `^`
Divide | `/`

## Notes
```c#
// Your note here
```
These lines are not read by the parser
## `Main` Function
```c#
namespace app.net.com
{
   external class extends EXTENTION_CLASS
   {
        fx Main()
        {
            // MAIN FUNCTION
        }
   }
}
```
This function will be called on start 
<br><br>

## Change `Main` function name
```c#
[Main = STRING];
```
This will change the main function that will be called on start
<br><br>

## If Else Statements
```c#
if(SITUATION){}
else if(SITUATION){}
else{}
```
## Try Catch
```c#
try
{
    // CODE
}
catch(ExceptionType VALUE)
{
    // CODE
}
```
## Throw Exception
```c#
throw new exception(ExceptionType);
```
## Console Logging
#### Same Line Printing

```c#
console.out.print(STRING);
```
#### New Line Printing
```c#
console.out.printLine(STRING);
```

## Defining Variable
```c#
set x = VALUE;
```
`set` will automaticaly assign a variable type based on the value. Note: This is a non static type.

Name | Type
-----|-----
Integer | `int`
Float | `float`
Double | `dbl`
Boolean | `bool`
String | `string`
Character | `char`
Set | ***Dynamic***

## Defining Function
```c#
fx FUNCTION_NAME(TYPE name) -> RETURN_TYPE
{
    // Do Stuff
}
 ```

## Create Window
```c#
new (Window)window = Window.instance.new(
    {
        title: STRING,
        size: TUPLE,
        3dRenderingMode: BOOLEAN,
        Frame: BOOLEAN,
        startFullscreen: BOOLEAN,
        resizable: BOOLEAN
    }
);
```
This will create a instance of the `Window` builtin class
<br><br>

## Window Hint
```c#
window.hint(HINT_TYPE, HINT_VALUE);
```
`window` is your instance of the `Window` builtin class. This will change the classes internal variables.

## Debug Label
```c#
window.debug.log(STRING);
```
This will be shown when run threw the interperter window but not on the final build.

