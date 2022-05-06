# Jaeger
.NET 5.0

1. install packages 
OpenTracing.Contrib.NetCore
Jaeger.Core
Jaeger.Senders.Thrift

2.
public void ConfigureServices(IServiceCollection services)
        {
            services.AddOpenTracing();

            services.AddSingleton<ITracer>(serviceProvider =>
            {
                var serviceName = serviceProvider.GetRequiredService<IWebHostEnvironment>().ApplicationName;
                var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
                var endpoint = "http://vcs.sb.gazprom.ru:16686/api/traces";

                // This is necessary to pick the correct sender, otherwise a NoopSender is used!
                //Jaeger.Configuration.SenderConfiguration.DefaultSenderResolver = new SenderResolver(loggerFactory).RegisterSenderFactory<ThriftSenderFactory>();

                /*
                var remoteReporter = new RemoteReporter.Builder()
                    .WithLoggerFactory(loggerFactory) // optional, defaults to no logging
                    .WithMaxQueueSize(100)            // optional, defaults to 100
                    .WithFlushInterval(TimeSpan.FromSeconds(1)) // optional, defaults to TimeSpan.FromSeconds(1)
                    .WithSender(new HttpSender(endpoint))   // optional, defaults to UdpSender("localhost", 6831, 0)
                    .Build();

                // This will log to a default localhost installation of Jaeger.
                var tracer = new Tracer.Builder(serviceName)
                    .WithLoggerFactory(loggerFactory)
                    .WithSampler(new ConstSampler(true))
                    .WithReporter(remoteReporter)
                    .Build();
                */

                var sender = new HttpSender(endpoint);
                //var sender = new UdpSender("vcs.sb.gazprom.ru", 6831, 0);

                var remoteReporter = new RemoteReporter.Builder()
                    .WithLoggerFactory(loggerFactory) // optional, defaults to no logging
                    .WithMaxQueueSize(100)            // optional, defaults to 100
                    .WithFlushInterval(TimeSpan.FromSeconds(1)) // optional, defaults to TimeSpan.FromSeconds(1)
                    .WithSender(sender)   // optional, defaults to UdpSender("localhost", 6831, 0)
                    .Build();
                var loggingReporter = new LoggingReporter(loggerFactory);
                var compositeReporter = new CompositeReporter(remoteReporter, loggingReporter);
                var sampler = new ConstSampler(true);

                ITracer tracer = new Tracer.Builder(serviceName)
                    .WithSampler(sampler)
                    .WithReporter(compositeReporter)
                    .Build();
                

                // Allows code that can't use DI to also access the tracer.
                GlobalTracer.Register(tracer);

                return tracer;
            });

            services.AddControllers();
        }
