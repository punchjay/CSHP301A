# Exercise 2 - Gibble Jay ejg2

- Included is Path Core + Test Automation for PurchasePrice

- PurchasePriceUnitTest.cs
Not sure what's going on here? namespace should NOT be VendingMachine, but this got the tests to work.
Is this a Dependency Assemblie issue? Because namespace for StringUnitTest.cs works just fine.
```
using VendingMachine;
//namespace PurchasePriceUnitTest 
namespace VendingMachine
```
VS Error: "PurchasePrice initialPrice is namespace but being used as type"

- Implemented David's feedback from exercise01

