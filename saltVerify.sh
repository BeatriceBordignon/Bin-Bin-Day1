#!/usr/bin/env zsh

# cd to the location of the script
SCRIPTPATH="$( cd "$(dirname "$0")" >/dev/null 2>&1 ; pwd -P )"
cd $SCRIPTPATH

echo "Building..."
buildresult=$(dotnet build)
if [[ "$buildresult" != *"Build succeeded"* ]]
then
  echo "Build verified - NOT OK"
  echo $buildresult
  exit 1
fi

echo "Testing..."
testresult=$(dotnet test --nologo -v:q)
if [[ $testresult != *"10, Passed:"* ]]
then
  dotnet clean > /dev/null

  echo "Tests verified - NOT OK"
  echo $testresult
  exit 1
fi

# Clean temp files
dotnet clean > /dev/null

# cd back to where we came from
cd - > /dev/null

echo "Installation, building and testing verified - OK"
exit 0