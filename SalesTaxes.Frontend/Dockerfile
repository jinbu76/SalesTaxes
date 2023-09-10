# Stage 1: Build an Angular Docker Image
FROM node:lts as build
WORKDIR /apps
COPY SalesTaxes.Frontend/ .
RUN npm install
COPY . /apps
RUN npm run build:prod
# Stage 2, use the compiled app, ready for production with Nginx
FROM nginx:alpine
COPY SalesTaxes.Frontend/nginx.conf /etc/nginx/conf.d/
RUN rm -rf /usr/share/nginx/html/*
COPY --from=build /apps/build /usr/share/nginx/html
