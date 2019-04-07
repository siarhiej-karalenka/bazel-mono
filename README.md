# bazel-mono - Bazel builds Mono
This is a Hello World project that uses the [Bazel](https://bazel.build) build tool to build a simple [Mono](https://mono-project.com) console application. This project leverages [.NET rules for Bazel](https://github.com/bazelbuild/rules_dotnet) project.
It is developed and run on Linux Ubuntu 18.04.

## Pre-requisites
Before proceeding to running it, install the following tools:
1. Install Mono: https://www.mono-project.com/download/stable/#download-lin
1. Install Bazel: https://docs.bazel.build/versions/master/install-ubuntu.html

## Downloading and Running
Retrieve this project from Github:

`$ git clone git@github.com:siarhiej-karalenka/bazel-mono.git`

Navigate to the bazel-mono directory:

`$ cd bazel-mono/`

Run it:

`$ bazel build //:hello --spawn_strategy=standalone`


Verify it is working:

`$ mono bazel-bin/hello.exe`

It should output:
`Hello from Greeter`

