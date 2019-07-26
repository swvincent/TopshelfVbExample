# Topshelf example for Visual Basic.NET

[Topshelf](http://topshelf-project.com/) is a framework for .NET that makes creating Windows services incredibly easy. The official documentation includes an [example](https://topshelf.readthedocs.io/en/latest/configuration/quickstart.html) that illustrates how it works using C#, but I needed to use it in Visual Basic.NET. I created this example for anybody else who may need to do the same.

The biggest difference from the original example (besides using VB) is that I implemented the Topshelf.ServiceControl interface in the TownCrier class which results in cleaner code (IMHO).

Credit goes to Cole Francis for [his excellent C# example](https://mobiusstraits.com/2018/02/06/using-topshelf-to-create-easily-create-a-net-windows-service/) which illustrates using the ServiceControl interface.
