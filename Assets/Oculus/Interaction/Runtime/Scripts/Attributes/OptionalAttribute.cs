/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using UnityEngine;

namespace Oculus.Interaction
{
    /// <summary>
    /// Used on a SerializedField surfaces the expectation that this field can remain empty.
    /// </summary>
    public class OptionalAttribute : PropertyAttribute
    {
        [System.Flags]
        public enum Flag
        {
            /// <summary>
            /// Presents the Optional tag and moves it into the Optional Section
            /// </summary>
            None = 0,
            /// <summary>
            /// Indicates that if the reference is missing, a new object will be
            /// created and linked to it during runtime.
            /// </summary>
            AutoGenerated = 1 << 0,
            /// <summary>
            /// Indicates that even though the reference is Optional, it is important
            /// for the component to work as expected.
            /// </summary>
            DontHide = 1 << 1
        }

        public Flag Flags { get; private set; } = Flag.None;

        public OptionalAttribute() { }

        public OptionalAttribute(Flag flags)
        {
            Flags = flags;
        }
    }
}
