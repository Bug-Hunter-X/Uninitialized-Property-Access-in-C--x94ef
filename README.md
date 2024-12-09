# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that hasn't been initialized. This can lead to a `NullReferenceException` at runtime.

## The Bug
The `MyClass` class has a property `MyProperty` of type `int`. In the `MyMethod` method, we attempt to use this property before assigning a value to it.  This results in a `NullReferenceException` because the property is null by default for value types.