export interface Attack {           //model na data v tabulke
    id: number;
    message: string;
    severity: number;
    timestamp: Date;
    src_ip: string;
    dest_ip: string;
    proto: string;
    severityCategory: string;
}