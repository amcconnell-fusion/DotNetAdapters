DotNetAdapters
==============

A collection of interfaces and corresponding adapters wrapping a variety of classes in the .NET Framework.

# Requirements for Contributions #
Before submitting a pull request:

- Please provide XML Documentation for all public types and members.
- Please ensure that you have automated test coverage for any code that contains logic beyond invoking the functionality of the adapted type.
	- Most types should simply wrap the native methods, and therefore automated tests will not normally be required (or desired).
- Please ensure that all automated tests pass.
- Please run the ReSharper *Code Cleanup* tool using the *FusionDotNet* profile.

