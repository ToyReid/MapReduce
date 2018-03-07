# Simple makefile so you don't have to type it all out

all: driver.exe

driver.exe: Map.cs Reduce.cs MapReduce.cs DataReader.cs DataReaderEnum.cs Driver.cs
	@mcs -out:driver.exe Map.cs Reduce.cs MapReduce.cs DataReader.cs DataReaderEnum.cs Driver.cs

clean:
	@rm -f driver.exe