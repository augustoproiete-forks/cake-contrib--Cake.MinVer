﻿// Copyright 2020 C. Augusto Proiete & Contributors
//
// Licensed under the MIT (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://opensource.org/licenses/MIT
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Cake.Core.IO;
using Cake.Testing.Fixtures;

namespace Cake.MinVer.Tests.Support
{
    internal class MinVerToolFixtureResult : ToolFixtureResult
    {
        public MinVerToolFixtureResult(FilePath path, ProcessSettings process)
            : base(path, process)
        {
        }

        public MinVerVersion Version { get; set; }
    }
}
