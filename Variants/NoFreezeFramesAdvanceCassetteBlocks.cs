﻿using System;

namespace ExtendedVariants.Variants {
    public class NoFreezeFramesAdvanceCassetteBlocks : AbstractExtendedVariant {
        public override Type GetVariantType() {
            return typeof(bool);
        }

        public override object GetDefaultVariantValue() {
            return false;
        }

        public override object ConvertLegacyVariantValue(int value) {
            return value != 0;
        }
    }
}
