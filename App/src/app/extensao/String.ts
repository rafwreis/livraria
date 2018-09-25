//Forma 1

// export {}

// declare global {
//     interface String {
//         isNullOrEmpty: (val: any) => boolean;
//     }
// }

// String.prototype.isNullOrEmpty = function (val: any): boolean {  
//     if (val === undefined || val === null || val.trim() === '') {
//         return true;
//     }
//     return false;
// };

// Forma 2
interface StringConstructor {  
    isNullOrEmpty: (val: any) => boolean;
    empty: () => String;
}

String.isNullOrEmpty = function (val: any): boolean {
    if (val === undefined || val === null || val.trim() === '') {
        return true;
    }
    return false;
};

String.empty = function(): String {
    return "";
}











