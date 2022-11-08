# Test Assignment 4

## Moq
### How do you verify that a mock was called?
We use Moq's _mock.Verify() method to verify that the mock was called
<p align="center">
  <img src="Pictures/verifymock.PNG" height="700" width="1300" title="hover text">
</p>

### How do you verify that a mock was not called?
we insert Times.never() to specify verify that the mock was never called
<p align="center">
  <img src="Pictures/notcalledmock.PNG" height="700" width="1300" title="hover text">
</p>

### How do you specify how many times a mock should have been called?
We again use Times.xxx to specify how many times a mock should have been called. In our example we used Exactly(2) to specify that the mock should have been called twice - it fails because it was only called once. 
<p align="center">
  <img src="Pictures/exactlymock.PNG" height="700" width="1300" title="hover text">
</p>

### How do you specify that a mock was called with specific arguments?
As seen in the photo, we use the Verify() method to specify that the method is to be called with a specific argument
<p align="center">
  <img src="Pictures/specifyargument.PNG" height="700" width="1300" title="hover text">
</p>

### How do you use a predicate to verify the properties of the arguments given to a call to the mock?
We use the Is.itAny to define what type the argument of the method can use, and not checking the actual value compared to the previous example
<p align="center">
  <img src="Pictures/predicate.PNG" height="700" width="1300" title="hover text">
</p>