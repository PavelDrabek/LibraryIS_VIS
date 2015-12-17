using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.MapperLogic {
    class WrongDataSourceException : Exception {
        public WrongDataSourceException() {
        }

        public WrongDataSourceException(string message)
            : base(message) {
        }

        public WrongDataSourceException(string message, Exception inner)
            : base(message, inner) {
        }
    }
}
