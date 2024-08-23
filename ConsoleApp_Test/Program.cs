using ConsoleApp_Test;

IWorker tester;

tester = new WorkWithFiles();
tester.InvokeTest();


tester = new WorkWithPaths();
tester.InvokeTest();