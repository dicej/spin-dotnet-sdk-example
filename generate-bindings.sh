#!/bin/sh

set -ex

dotnet restore
# TODO: update to next release containing https://github.com/bytecodealliance/wit-bindgen/pull/1017
cargo install --locked --no-default-features --features csharp --git https://github.com/dicej/wit-bindgen --rev e9430c5a wit-bindgen-cli --root $(pwd)
./bin/wit-bindgen c-sharp -w fermyon:spin/spin-http -r native-aot .packages/fermyon.spin.sdk/0.1.0-dev/content/SpinHttpWorld_component_type.wit
rm SpinHttpWorld_component_type.* SpinHttpWorld_cabi_realloc.c SpinHttpWorld_wasm_import_linkage_attribute.cs SpinHttpWorld.wit.imports.* SpinHttp.cs
