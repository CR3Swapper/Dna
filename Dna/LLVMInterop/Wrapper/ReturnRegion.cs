﻿using Dna.LLVMInterop.Native;
using LLVMSharp.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dna.LLVMInterop.Wrapper
{
    public unsafe class ReturnRegion : ComplexRegion
    {
        public LLVMValueRef ReturnInstruction => new LLVMValueRef(NativeReturnRegionApi.ReturnRegionGetLLVMReturnInstruction(handle));

        public ReturnRegion(nint handle) : base(handle)
        {

        }
    }
}
