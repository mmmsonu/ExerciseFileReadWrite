Summary
-------

Please complete the two coding exercise steps: a brief code review and then a refactor
of a class.
We do not expect you to spend more than two to three hours on this exercise.

Exercise
--------

A junior developer was tasked with writing a reusable implementation to read and write
text files that hold tab separated data (CSV).
This implementation is used by a bulk email application -- BulkEmailProcessor class.
Consider this class as the client code. You won't need to change this code.

The junior wrote the CSVReaderWriter class.
Although it works and meets the present needs of the application, it has some draw backs
that we would like you to find.

Your task:

   0) Confirm that you can build the solution and run the unit tests.
      There is only one test and it is passing.
      We recommend (not require) Visual Studio for this, see the notes at the bottom.
      This step does not require any specific action from you.

   1) Review the CSVReaderWriterForAnnotation.cs file and using the comments section
      at the top, list three to five key areas of concern that you would discuss with
      the junior developer. This is a quick review so please don't spend more than 
      15/20 minutes on this task. Please, don't change any other line of code in this
      file other than the comment section.

   2) Refactor the CSVReaderWriter implementation into clean, elegant, well performing
      and maintainable code, as you see fit.
      You should not update the BulkEmailProcessor as part of this task.
      Backwards compatibility of the CSVReaderWriter must be maintained, so that the 
      existing BulkEmailProcessor is not broken.
      Other that that, you can make any change you see fit, even to the code structure.

Notes:
  - Where you make trade offs, comment & explain why. 
  - You'll notice there are some other files in the BulkEmail project that aren't
    relevant. These will come into play in the next stage in the interview process
    and can be ignored for now.
  - You may introduce nuget based references.
  - If you need a copy of visual studio you can use the free edition available
    to download from: http://www.visualstudio.com/downloads/
  - To view and run the unit tests, you can:
      - (recommended) install Visual Studio Extension "NUnit 2 Test Adapter"
      - use visual studio with Resharper (trial or with a license)
      - run the unit tests from console (http://nunit.org/docs/2.6/nunit-console.html)
  - Git is integral to our process but we understand that not everyone has previous 
    experience with the tool. If you're not yet familiar with Git we recommend that
    you read some online tutorials and use the SmartGit client.
    To get started or visit http://git-scm.com/ for the official git client.

