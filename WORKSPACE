load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    commit = "7415223490a46acea4924cef7291dcfe59b4f45f",
    shallow_since = "1552245733 +0100",
)

load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "mono_register_sdk",
    "dotnet_register_toolchains", "dotnet_repositories")

dotnet_register_toolchains()
dotnet_repositories()
mono_register_sdk()
