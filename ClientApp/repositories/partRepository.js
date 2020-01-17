"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var partRepository = /** @class */ (function () {
    function partRepository(http) {
        this.http = http;
    }
    partRepository.prototype.getAllParts = function () {
        return this.http.get('parts/GetAllParts');
    };
    return partRepository;
}());
exports.partRepository = partRepository;
//# sourceMappingURL=partRepository.js.map